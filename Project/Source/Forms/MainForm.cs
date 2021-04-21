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

namespace Ordisoftware.TwitterManager
{

  public partial class MainForm : Form
  {

    static internal Tokens TwitterTokens;

    static internal readonly List<Tweet> Tweets = new List<Tweet>();

    internal readonly Properties.Settings Settings = Properties.Settings.Default;

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

    private void ActionConnectTwitter_Click(object sender, EventArgs e)
    {
      var session = OAuth.Authorize("",
                                    "",
                                    "");
      System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);
      string pin = "";
      DisplayManager.QueryValue("Twitter Access", "Pin Code", ref pin);
      if ( pin == "" ) return;
      TwitterTokens = session.GetTokens(pin);
      DisplayManager.Show("Connected to: @" + TwitterTokens.ScreenName);
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
