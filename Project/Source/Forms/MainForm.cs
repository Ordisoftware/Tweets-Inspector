/// <license>
/// This file is part of Ordisoftware Twitter Manager.
/// Copyright 2021 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2021-04 </created>
/// <edited> 2021-04 </edited>
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CoreTweet;
using Ordisoftware.Core;
using System.Drawing;
using System.Threading.Tasks;

namespace Ordisoftware.TwitterManager
{

  public partial class MainForm : Form
  {

    private const string OAuthVerifierTag = "oauth_verifier";
    private const int APIStep = 50;

    static internal readonly string FilterMain = "Type = " + (int)TweetType.Main;
    static internal readonly string FilterReplies = "Type = " + (int)TweetType.Reply;
    static internal readonly string FilterRTs = "Type = " + (int)TweetType.RT;

    static internal readonly MainForm Instance;
    static internal readonly Properties.Settings Settings = Program.Settings;
    static internal Tokens TwitterTokens { get; private set; }

    static MainForm()
    {
      Instance = new MainForm();
    }

    internal static bool IsConnected(bool showMessage)
    {
      if ( TwitterTokens == null )
      {
        if (showMessage) DisplayManager.ShowWarning("Not connected.");
        return false;
      }
      return true;
    }

    public MainForm()
    {
      InitializeComponent();
      Text = $"{Globals.AssemblyTitle} - Not connected";
      SystemManager.TryCatch(() => { Icon = new Icon(Globals.ApplicationIconFilePath); });
      TweetsControl.Modified += TweetsControl_OnModified;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      CreateSchemaIfNotExists();
      TweetsTableAdapter.Fill(DataSet.Tweets);
      UpdateListViews();
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Save();
    }

    private void ActionOpenMessages_Click(object sender, EventArgs e)
    {
      DoOpenMessages();
    }

    private void ActionSaveTweets_Click(object sender, EventArgs e)
    {
      /*if ( string.IsNullOrEmpty(LastTweetsFilePath) ) return;
      string path = Path.GetDirectoryName(LastTweetsFilePath);
      string name = Path.GetFileNameWithoutExtension(LastTweetsFilePath);
      File.WriteAllLines(Path.Combine(path, name + " - Tweets.txt"), SelectTweets.Items.Cast<string>());
      File.WriteAllLines(Path.Combine(path, name + " - Replies.txt"), SelectTweetsReply.Items.Cast<string>());
      File.WriteAllLines(Path.Combine(path, name + " - RT.txt"), SelectTweetsRT.Items.Cast<string>());*/
    }

    private async void ActionConnectTwitter_Click(object sender, EventArgs e)
    {
      if ( IsConnected(false) ) return;
      Enabled = false;
      bool done = false;
      var session = OAuth.Authorize(Settings.TwitterKey, Settings.TwitterSecret, Settings.TwitterBackUrl);
      var form = new WebBrowserForm();
      form.FormClosed += (_s, _e) => done = true;
      form.WebBrowser.AddressChanged += (_s, _e) => done |= _e.Address.Contains(Settings.TwitterBackUrl);
      form.WebBrowser.Load(session.AuthorizeUri.AbsoluteUri);
      form.Show();
      while ( !done ) await Task.Delay(100);
      if ( form.Visible ) form.Close();
      this.ForceBringToFront();
      Enabled = true;
      var items = form.WebBrowser.Address.SplitNoEmptyLines($"&{OAuthVerifierTag}=");
      if ( items.Length == 2 && items[1].Trim() != "" )
      {
        TwitterTokens = session.GetTokens(items[1]);
        Text = $"{Globals.AssemblyTitle} - Connected @{TwitterTokens.ScreenName}";
      }
      else
        DisplayManager.ShowWarning($"Tag not found : {OAuthVerifierTag}");
    }

    private void ActionLoadTweestFromJS_Click(object sender, EventArgs e)
    {
      DoLoadTweetsFromJS();
      UpdateListViews();
    }

    private void UpdateListViews()
    {
      TweetsControl.ListTweetsMain.DataSource = TweetsBindingSourceMain;
      TweetsControl.ListTweetsReplies.DataSource = TweetsBindingSourceReplies;
      TweetsControl.ListTweetsRTs.DataSource = TweetsBindingSourceRTs;
      TweetsControl.RefreshFilters();
      TweetsControl_OnModified(null, null);
    }

    private void TweetsControl_OnModified(object sender, EventArgs e)
    {
      var array = DataSet.Tweets.SelectMany(t => t.RecipientsAsList).Distinct().OrderBy(recipient => recipient).ToArray();
      ListBoxAllRecipients.Items.AddRange(array);
      LabelCountTweetsMain.Text = TweetsControl.ListTweetsMain.DataGridView.RowCount.ToString();
      LabelCountTweetsReplies.Text = TweetsControl.ListTweetsReplies.DataGridView.RowCount.ToString();
      LabelCountTweetsRTs.Text = TweetsControl.ListTweetsRTs.DataGridView.RowCount.ToString();
      LabelCountAllRecipients.Text = array.Length.ToString();
    }

    private void EditSearch_CheckedChanged(object sender, EventArgs e)
    {
      if ( !EditSearchUser.Checked && !EditSearchInMessage.Checked )
      {
        EditSearchUser.Checked = true;
        EditSearchInMessage.Checked = true;
      }
      TweetsControl.RefreshFilters();
    }

    private void ActionDelete_Click(object sender, EventArgs e)
    {
      if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
        if ( !IsConnected(true) ) return;
      bool modified = false;
      void onModified(object _s, EventArgs _e) => modified = true;
      TweetsControl.Modified -= TweetsControl_OnModified;
      TweetsControl.Modified += onModified;
      TweetsControl.ListTweetsMain.ActionDelete.PerformClick();
      TweetsControl.ListTweetsReplies.ActionDelete.PerformClick();
      TweetsControl.ListTweetsRTs.ActionDelete.PerformClick();
      TweetsControl.Modified -= onModified;
      TweetsControl.Modified += TweetsControl_OnModified;
      if (modified) TweetsControl_OnModified(null, null);
    }

    private void ActionSelectAll_Click(object sender, EventArgs e)
    {
      TweetsControl.ListTweetsMain.ActionSelectAll.PerformClick();
      TweetsControl.ListTweetsReplies.ActionSelectAll.PerformClick();
      TweetsControl.ListTweetsRTs.ActionSelectAll.PerformClick();
    }

    private void ActionSelectNone_Click(object sender, EventArgs e)
    {
      TweetsControl.ListTweetsMain.ActionSelectNone.PerformClick();
      TweetsControl.ListTweetsReplies.ActionSelectNone.PerformClick();
      TweetsControl.ListTweetsRTs.ActionSelectNone.PerformClick();
    }

    private void ActionFilterClear_Click(object sender, EventArgs e)
    {
      EditSearch.Text = "";
    }

    private void EditSearch_TextChanged(object sender, EventArgs e)
    {
      TweetsControl.ListTweetsMain.EditFilter.Text = EditSearch.Text;
      TweetsControl.ListTweetsReplies.EditFilter.Text = EditSearch.Text;
      TweetsControl.ListTweetsRTs.EditFilter.Text = EditSearch.Text;
    }

    private void ListBoxAllRecipients_DoubleClick(object sender, EventArgs e)
    {
      EditSearch.Text = ListBoxAllRecipients.SelectedItem.ToString();
    }

    private void ActionGetFollowers_Click(object sender, EventArgs e)
    {
      int count = APIStep;
      var users = new List<User>();
      long? cursor = null;
      while ( count == APIStep )
      {
        var list = TwitterTokens.Followers.List(TwitterTokens.UserId, count: APIStep, cursor: cursor);
        cursor = list.NextCursor;
        count = list.Count;
        users.AddRange(list.ToList());
      }
      DisplayManager.Show(string.Join(", ", users.Select(user => user.ScreenName)));
    }

    private void ActionGetFellowing_Click(object sender, EventArgs e)
    {
      int count = APIStep;
      var users = new List<User>();
      long? cursor = null;
      while ( count == APIStep )
      {
        var list = TwitterTokens.Friends.List(TwitterTokens.UserId, count: APIStep, cursor: cursor);
        cursor = list.NextCursor;
        count = list.Count;
        users.AddRange(list.ToList());
      }
      DisplayManager.Show(string.Join(", ", users.Select(user => user.ScreenName)));
    }

    private void ActionGetLikes_Click(object sender, EventArgs e)
    {
      var list = TwitterTokens.Favorites.List(TwitterTokens.UserId, count: 200);
      foreach ( var item in list )
      {
        if ( item.User.ScreenName.ToLower().Contains("") )
          ;
      }
    }

  }

}
