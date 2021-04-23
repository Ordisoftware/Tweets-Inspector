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
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Ordisoftware.Core;
using System.Windows.Forms;

namespace Ordisoftware.TweetsInspector
{

  public partial class MainForm
  {

    private void DoLoadTweetsFromJS()
    {
      Cursor = Cursors.WaitCursor;
      try
      {
        var command = new OdbcCommand("DELETE FROM Tweets", LockFileConnection);
        command.ExecuteNonQuery();
        TweetsTableAdapter.Fill(DataSet.Tweets);
        TweetsBindingSourceMain.ResetBindings(false);
        TweetsBindingSourceReplies.ResetBindings(false);
        TweetsBindingSourceRTs.ResetBindings(false);
        Refresh();
        string filepath = @"c:\Users\Olivier\Projects\Social\Twitter\tweet.js";
        var lines = File.ReadAllLines(filepath);
        lines[0] = lines[0].Replace("window.YTD.tweet.part0 = ", "");
        LoadingForm.Instance.Initialize("Loading JS...", 1);
        dynamic tweets = JArray.Parse(string.Join(Environment.NewLine, lines));
        LoadingForm.Instance.DoProgress();
        LoadingForm.Instance.Initialize(SysTranslations.ProgressCreatingData.GetLang(), ( (JArray)tweets ).Count);
        try
        {
          foreach ( var item in tweets )
          {
            LoadingForm.Instance.DoProgress();
            var row = DataSet.Tweets.NewTweetsRow();
            row.Id = (string)item.tweet.id;
            row.Date = (string)item.tweet.created_at;
            row.Message = (string)item.tweet.full_text;
            var recipients = new List<string>();
            string replyto = (string)item.tweet.in_reply_to_screen_name;
            if ( !replyto.IsNullOrEmpty() ) recipients.Add(replyto);
            foreach ( JToken mention in item.tweet.entities.user_mentions )
            {
              string recipient = (string)mention["screen_name"];
              if ( !recipients.Contains(recipient) )
                recipients.Add(recipient);
            }
            row.Recipients = string.Join(",", recipients);
            if ( row.Message.StartsWith("RT @") )
              row.Type = (int)TweetType.RT;
            else
            if ( row.Message.StartsWith("@") )
              row.Type = (int)TweetType.Reply;
            else
              row.Type = (int)TweetType.Main;
            DataSet.Tweets.AddTweetsRow(row);
          }
          TableAdapterManager.UpdateAll(DataSet);
          SaveUsingTransaction(DataSet.Tweets, TweetsTableAdapter.Adapter);
        }
        catch
        {
          throw;
        }
      }
      finally
      {
        LoadingForm.Instance.Hide();
        Cursor = Cursors.Default;
      }
    }

    private void SaveUsingTransaction(DataTable table, OdbcDataAdapter adapter)
    {
      string str = SysTranslations.ProgressSavingData.GetLang() + " " + table.TableName;
      LoadingForm.Instance.Initialize(str, table.Rows.Count, 0, true, 100);
      adapter.RowUpdated += update;
      adapter.InsertCommand.Connection.Open();
      adapter.InsertCommand.Transaction = adapter.InsertCommand.Connection.BeginTransaction();
      adapter.Update(table);
      try
      {
        adapter.InsertCommand.Transaction.Commit();
      }
      catch
      {
        adapter.InsertCommand.Transaction.Rollback();
        TweetsTableAdapter.Fill(DataSet.Tweets);
        TweetsTableAdapter.Fill(DataSet.Tweets);
        TweetsBindingSourceMain.ResetBindings(false);
        TweetsBindingSourceReplies.ResetBindings(false);
        TweetsBindingSourceRTs.ResetBindings(false);
      }
      adapter.InsertCommand.Connection.Close();
      adapter.RowUpdated -= update;
      void update(object sender, OdbcRowUpdatedEventArgs rowEvent)
      {
        if ( !Globals.IsGenerating ) LoadingForm.Instance.DoProgress();
      };
    }

  }

}