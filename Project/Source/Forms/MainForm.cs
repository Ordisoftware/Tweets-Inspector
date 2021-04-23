/// <license>
/// This file is part of Ordisoftware Tweets Inspector.
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

namespace Ordisoftware.TweetsInspector
{

  // TODO encrypt login

  public partial class MainForm : Form
  {

    private const string OAuthVerifierTag = "oauth_verifier";
    private const int APIStep = 50;

    static internal readonly MainForm Instance;
    static internal readonly Properties.Settings Settings = Program.Settings;
    static internal OAuth.OAuthSession Session { get; private set; }
    static internal Tokens Tokens { get; private set; }

    static MainForm()
    {
      Instance = new MainForm();
    }

    internal static bool IsConnected(bool showMessage)
    {
      if ( Tokens != null ) return true;
      if (showMessage) DisplayManager.ShowWarning("Not connected.");
      return false;
    }

    public MainForm()
    {
      InitializeComponent();
      TabControl.TabPages.Remove(TabPageMessages);
      SettingsBindingSource.DataSource = Settings;
      TweetsControl.Modified += TweetsControl_OnModified;
      Text = $"{Globals.AssemblyTitle} - Not connected";
      SystemManager.TryCatch(() => { Icon = new Icon(Globals.ApplicationIconFilePath); });
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      CreateSchemaIfNotExists();
      TweetsTableAdapter.Fill(DataSet.Tweets);
      UpdateListViews();
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
      if ( Settings.ConnectAtStartup )
        ActionConnect.PerformClick();
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Save();
    }

    private void ActionOpenMessages_Click(object sender, EventArgs e)
    {
      DoOpenMessages();
    }

    private void ActionSaveToCSV_Click(object sender, EventArgs e)
    {
      /*if ( string.IsNullOrEmpty(LastTweetsFilePath) ) return;
      string path = Path.GetDirectoryName(LastTweetsFilePath);
      string name = Path.GetFileNameWithoutExtension(LastTweetsFilePath);
      File.WriteAllLines(Path.Combine(path, name + " - Tweets.txt"), SelectTweets.Items.Cast<string>());
      File.WriteAllLines(Path.Combine(path, name + " - Replies.txt"), SelectTweetsReply.Items.Cast<string>());
      File.WriteAllLines(Path.Combine(path, name + " - RT.txt"), SelectTweetsRT.Items.Cast<string>());*/
    }

    private async void ActionConnect_Click(object sender, EventArgs e)
    {
      if ( IsConnected(false) ) return;
      if ( Settings.ConsumerKey == "" || Settings.ConsumerSecret == "" || Settings.ConsumerBackUrl == "" ) return;
      Enabled = false;
      bool done = false;
      bool cancelled = false;
      Session = OAuth.Authorize(Settings.ConsumerKey, Settings.ConsumerSecret, Settings.ConsumerBackUrl);
      var form = new WebBrowserForm();
      form.FormClosed += (_s, _e) => cancelled = !done;
      form.WebBrowser.AddressChanged += (_s, _e) => done |= _e.Address.Contains(Settings.ConsumerBackUrl);
      form.WebBrowser.Load(Session.AuthorizeUri.AbsoluteUri);
      form.Show();
      while ( !done && !cancelled ) await Task.Delay(100);
      if ( form.Visible ) form.Close();
      this.ForceBringToFront();
      Enabled = true;
      if ( cancelled ) return;
      var items = form.WebBrowser.Address.SplitNoEmptyLines($"&{OAuthVerifierTag}=");
      if ( items.Length == 2 && items[1].Trim() != "" )
      {
        Tokens = Session.GetTokens(items[1]);
        Text = $"{Globals.AssemblyTitle} - Connected @{Tokens.ScreenName}";
        ActionConnect.Enabled = false;
      }
      else
        DisplayManager.ShowWarning($"Tag not found : {OAuthVerifierTag}");
    }

    private void ActionLoadFromJS_Click(object sender, EventArgs e)
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
      var array = DataSet.Tweets
                         .SelectMany(t => t.RecipientsAsList)
                         .Distinct()
                         .OrderBy(recipient => recipient)
                         .ToArray();
      ListBoxAllRecipients.Items.AddRange(array);
      LabelCountTweetsMainValue.Text = TweetsControl.ListTweetsMain.DataGridView.RowCount.ToString();
      LabelCountTweetsRepliesValue.Text = TweetsControl.ListTweetsReplies.DataGridView.RowCount.ToString();
      LabelCountTweetsRTsValue.Text = TweetsControl.ListTweetsRTs.DataGridView.RowCount.ToString();
      LabelCountAllRecipientsValue.Text = array.Length.ToString();
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
      TweetsControl.DeleteSelected();
      TweetsControl.Modified -= onModified;
      TweetsControl.Modified += TweetsControl_OnModified;
      if (modified) TweetsControl_OnModified(null, null);
    }

    private void ActionSelectAll_Click(object sender, EventArgs e)
    {
      TweetsControl.SelectAll();
    }

    private void ActionSelectNone_Click(object sender, EventArgs e)
    {
      TweetsControl.SelectNone();
    }

    private void ActionFilterClear_Click(object sender, EventArgs e)
    {
      EditSearch.Text = "";
    }

    private void EditSearch_TextChanged(object sender, EventArgs e)
    {
      TweetsControl.SetSearchTerm(EditSearch.Text);
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
        var list = Tokens.Followers.List(Tokens.UserId, count: APIStep, cursor: cursor);
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
        var list = Tokens.Friends.List(Tokens.UserId, count: APIStep, cursor: cursor);
        cursor = list.NextCursor;
        count = list.Count;
        users.AddRange(list.ToList());
      }
      DisplayManager.Show(string.Join(", ", users.Select(user => user.ScreenName)));
    }

    private void ActionGetLikes_Click(object sender, EventArgs e)
    {
      var list = Tokens.Favorites.List(Tokens.UserId, count: 200);
      foreach ( var item in list )
      {
        if ( item.User.ScreenName.ToLower().Contains("") )
          ;
      }
    }

  }

}
