using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Ordisoftware.Core;
using System.Windows.Forms;

namespace TwitterManager
{

  public partial class MainForm
  {

    private void DoLoadTweestFromJS()
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        Tweets.Clear();
        string screenName = TwitterTokens == null || TwitterTokens.ScreenName.IsNullOrEmpty()
                            ? "ordisoftware"
                            : TwitterTokens.ScreenName;
        string filepath = @"c:\Users\Olivier\Projects\Social\Twitter\tweet.js";
        var lines = File.ReadAllLines(filepath);
        lines[0] = lines[0].Replace("window.YTD.tweet.part0 = ", "");
        dynamic tweets = JArray.Parse(string.Join(Environment.NewLine, lines));
        ProgressBar.Value = 0;
        ProgressBar.Maximum = ( (JArray)tweets ).Count;
        foreach ( var item in tweets )
        {
          ProgressBar.PerformStep();
          ProgressBar.Refresh();
          var recipients = new List<string>();
          var tweet = new Tweet();
          tweet.ScreenName = screenName;
          tweet.Id = (string)item.tweet.id;
          tweet.Date = (string)item.tweet.created_at;
          tweet.Message = (string)item.tweet.full_text;
          string replyto = (string)item.tweet.in_reply_to_screen_name;
          if ( !replyto.IsNullOrEmpty() ) recipients.Add(replyto);
          foreach ( JToken mention in item.tweet.entities.user_mentions )
          {
            string recipient = (string)mention["screen_name"];
            if ( !recipients.Contains(recipient))
              recipients.Add(recipient);
          }
          tweet.Recipients = string.Join(",", recipients);
          if ( tweet.Message.StartsWith("RT @") )
            tweet.Type = TweetType.RT;
          else
          if ( tweet.Message.StartsWith("@") )
            tweet.Type = TweetType.Reply;
          else
            tweet.Type = TweetType.Main;
          Tweets.Add(tweet);
        }
      }
      finally
      {
        Cursor = Cursors.Default;
        ProgressBar.Value = 0;
      }
    }

  }

}
