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

    static internal readonly Properties.Settings Settings = Program.Settings;

    static internal readonly List<Tweet> Tweets = new List<Tweet>();

    static internal Tokens TwitterTokens { get; private set; }

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
      SystemManager.TryCatch(() => { Icon = new Icon(Globals.ApplicationIconFilePath); });
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      CreateSchemaIfNotExists();
      LoadData();
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
        DisplayManager.Show("Connected to: @" + TwitterTokens.ScreenName);
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
      TweetsControl.Populate(Tweets);
      var array = Tweets.SelectMany(t => t.RecipientsAsList).Distinct().OrderBy(recipient => recipient).ToArray();
      ListBoxAllRecipients.Items.AddRange(array);
      LabelCountTweetsMain.Text = TweetsControl.ListTweetsMain.DataGridView.RowCount.ToString();
      LabelCountTweetsReplies.Text = TweetsControl.ListTweetsReplies.DataGridView.RowCount.ToString();
      LabelCountTweetsRTs.Text = TweetsControl.ListTweetsRTs.DataGridView.RowCount.ToString();
      LabelCountAllRecipients.Text = array.Length.ToString();
    }

    private void ActionSearch_Click(object sender, EventArgs e)
    {
      Search(EditSearch.Text);
    }

    private void ListBoxAllRecipients_DoubleClick(object sender, EventArgs e)
    {
      Search(ListBoxAllRecipients.SelectedItem.ToString());
    }

    private void Search(string term)
    {
      if ( EditSearchResultsShowInForm.Checked )
      {
        var query = from tweet in Tweets
                    where tweet.Id.ToString() == term
                       || tweet.Recipients.Contains(term)
                       || tweet.Message.Contains(term)
                    select tweet;
        if ( SearchResultForm.Run(query) )
          UpdateListViews();
      }
      else
      {
        TweetsControl.ListTweetsMain.SearchAndSelect(term);
        TweetsControl.ListTweetsReplies.SearchAndSelect(term);
        TweetsControl.ListTweetsRTs.SearchAndSelect(term);
      }
    }

    private const int APIStep = 50;

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

  }

}
