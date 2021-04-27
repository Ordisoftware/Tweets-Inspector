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
using System.Globalization;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Ordisoftware.Core;
using System.Windows.Forms;

namespace Ordisoftware.TweetsInspector
{

  public partial class MainForm
  {

    private const string TwitterDateTemplate = "ddd MMM dd HH:mm:ss +ffff yyyy";

    private readonly CultureInfo CultureEN = new CultureInfo("en-US");

    private void DoLoadTweetsFromJS()
    {
      Cursor = Cursors.WaitCursor;
      try
      {
        if ( DataSet.Tweets.Count > 0 )
          if ( !DisplayManager.QueryYesNo("Replace all tweets in the database?") ) return;
        if ( OpenFileDialogJS.ShowDialog() != DialogResult.OK ) return;
        LoadingForm.Instance.Initialize("Loading JS...", 1);
        string filepath = OpenFileDialogJS.FileName;
        var tweets = JsonHelper.LoadTweets(filepath);
        LoadingForm.Instance.DoProgress();
        LoadingForm.Instance.Initialize(SysTranslations.ProgressCreatingData.GetLang(), tweets.Count);
        var command = new OdbcCommand("DELETE FROM Tweets", LockFileConnection);
        command.ExecuteNonQuery();
        TweetsTableAdapter.Fill(DataSet.Tweets);
        TweetsBindingSourceMain.ResetBindings(false);
        TweetsBindingSourceReplies.ResetBindings(false);
        TweetsBindingSourceRTs.ResetBindings(false);
        Refresh();
        try
        {
          foreach ( var tweet in tweets )
          {
            LoadingForm.Instance.DoProgress();
            var row = DataSet.Tweets.NewTweetsRow();
            row.Id = tweet.Id;
            var date = DateTime.ParseExact(tweet.CreatedAt, TwitterDateTemplate, CultureEN);
            row.Date = SQLiteDate.ToString(date, true);
            row.Message = tweet.FullText;
            var recipients = new List<string>();
            string replyto = tweet.InReplyToScreenName;
            if ( !replyto.IsNullOrEmpty() ) recipients.Add(replyto);
            foreach ( var mention in tweet.Entities.UserMentions )
            {
              string recipient = mention.ScreenName;
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
