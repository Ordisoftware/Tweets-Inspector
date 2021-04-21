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

  }

}
