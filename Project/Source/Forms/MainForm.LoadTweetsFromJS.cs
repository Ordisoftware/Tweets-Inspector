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
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Ordisoftware.Core;
using System.Windows.Forms;

namespace Ordisoftware.TwitterManager
{

  public partial class MainForm
  {

    private void DoLoadTweetsFromJS()
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        Tweets.Clear();
        var transaction = LockFileConnection.BeginTransaction();
        var command = new OdbcCommand("DELETE FROM Tweets", LockFileConnection);
        command.Transaction = transaction;
        command.ExecuteNonQuery();
        string filepath = @"c:\Users\Olivier\Projects\Social\Twitter\tweet.js";
        var lines = File.ReadAllLines(filepath);
        lines[0] = lines[0].Replace("window.YTD.tweet.part0 = ", "");
        dynamic tweets = JArray.Parse(string.Join(Environment.NewLine, lines));
        ProgressBar.Value = 0;
        ProgressBar.Maximum = ( (JArray)tweets ).Count;
        try
        {
          foreach ( var item in tweets )
          {
            ProgressBar.PerformStep();
            ProgressBar.Refresh();
            var tweet = new Tweet();
            tweet.Id = long.Parse((string)item.tweet.id);
            tweet.Date = (string)item.tweet.created_at;
            tweet.Message = (string)item.tweet.full_text;
            var recipients = new List<string>();
            string replyto = (string)item.tweet.in_reply_to_screen_name;
            if ( !replyto.IsNullOrEmpty() ) recipients.Add(replyto);
            foreach ( JToken mention in item.tweet.entities.user_mentions )
            {
              string recipient = (string)mention["screen_name"];
              if ( !recipients.Contains(recipient) )
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
            command = new OdbcCommand("INSERT INTO Tweets VALUES (?,?,?,?,?)", LockFileConnection);
            command.Transaction = transaction;
            command.Parameters.Add("@Id", OdbcType.BigInt).Value = tweet.Id;
            command.Parameters.Add("@Date", OdbcType.Text).Value = tweet.Date;
            command.Parameters.Add("@Type", OdbcType.Int).Value = (int)tweet.Type;
            command.Parameters.Add("@Recipients", OdbcType.Text).Value = tweet.Recipients;
            command.Parameters.Add("@Message", OdbcType.Text).Value = tweet.Message;
            command.ExecuteNonQuery();
            Tweets.Add(tweet);
          }
          transaction.Commit();
        }
        catch
        {
          transaction.Rollback();
          throw;
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
