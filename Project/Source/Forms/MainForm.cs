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
/// <edited> 2021-08 </edited>
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CoreTweet;
using Ordisoftware.Core;
using System.Drawing;
using System.Data;
using System.Threading;

namespace Ordisoftware.TweetsInspector
{

  // TODO encrypt login

  public partial class MainForm : Form
  {

    private const int APIStep = 50;

    static internal readonly MainForm Instance;
    static internal readonly Properties.Settings Settings = Program.Settings;

    static private readonly DataTable UsersDataTable = new DataTable();

    static internal OAuth.OAuthSession Session { get; private set; }
    static internal Tokens Tokens { get; private set; }

    static MainForm()
    {
      Instance = new MainForm();
    }


    internal static bool IsConnected(bool showMessage)
    {
      if ( Tokens != null ) return true;
      if ( showMessage ) DisplayManager.ShowWarning("Not connected.");
      return false;
    }

    public MainForm()
    {
      InitializeComponent();
      TabControl.TabPages.Remove(TabPageMessages);
      SplitContainerMain.Panel1MinSize = TweetsControl.ListTweetsMain.MinimumSize.Width;
      Text = $"{Globals.AssemblyTitle} - Not connected";
      SystemManager.TryCatch(() => { Icon = new Icon(Globals.ApplicationIconFilePath); });
      UsersDataTable.Columns.Add("User", typeof(string));
      UsersDataTable.Columns.Add("Count", typeof(int));
      TweetsControl.Modified += TweetsControl_OnModified;
      SettingsBindingSource.DataSource = Settings;
      SelectStartupConnectAction.DataSource = Enum.GetValues(typeof(StartupConnectAction));
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      CreateSchemaIfNotExists();
      TweetsTableAdapter.Fill(DataSet.Tweets);
      TrashTableAdapter.Fill(DataSet.Trash);
      ListTweetsTrash.DataSource = TrashBindingSource;
      UpdateListViews();
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
      if ( Settings.StartupConnectAction == StartupConnectAction.Auto )
        ActionConnect.PerformClick();
      else
      if ( Settings.StartupConnectAction == StartupConnectAction.Ask )
        if ( DisplayManager.QueryYesNo("Connect to Twitter?") )
          ActionConnect.PerformClick();
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Save();
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
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

    private void ActionConnect_Click(object sender, EventArgs e)
    {
      DoConnect();
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
      Globals.IsGenerating = true;
      try
      {
        var users = DataSet.Tweets
                           .SelectMany(tweet => tweet.RecipientsAsList)
                           .GroupBy(recipient => recipient, (recipient, group) => new { recipient, count = group.Count() })
                           .Where(item => !item.recipient.IsNullOrEmpty())
                           .ToDictionary(item => item.recipient, item => item.count);
        foreach ( var item in users )
          UsersDataTable.Rows.Add(item.Key, item.Value);
        UsersBindingSource.DataSource = UsersDataTable;
        DataGridViewUsers.Sort(ColumnUserCount, System.ComponentModel.ListSortDirection.Descending);
        LabelCountTweetsMainValue.Text = TweetsControl.ListTweetsMain.DataGridView.RowCount.ToString();
        LabelCountTweetsRepliesValue.Text = TweetsControl.ListTweetsReplies.DataGridView.RowCount.ToString();
        LabelCountTweetsRTsValue.Text = TweetsControl.ListTweetsRTs.DataGridView.RowCount.ToString();
        LabelCountAllRecipientsValue.Text = users.Count().ToString();
      }
      finally
      {
        Globals.IsGenerating = false;
      }
    }

    private void EditFilterUsers_TextChanged(object sender, EventArgs e)
    {
      var ds = DataGridViewUsers.DataSource as BindingSource;
      if ( EditFilterUsers.Text != "" )
        ds.Filter = $"User LIKE '*{EditFilterUsers.Text}*'";
      else
        ds.Filter = "";
      DataGridViewUsers.ClearSelection();
    }

    private void DataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if ( e.RowIndex == -1 ) return;
      EditSearch.Text = (string)DataGridViewUsers[0, e.RowIndex].Value;
    }

    private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if ( !EditSingleClickUserFilter.Checked ) return;
      DataGridViewUsers_CellDoubleClick(sender, e);
    }

    private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
    {
      if ( Globals.IsGenerating ) return;
      if ( !EditSingleClickUserFilter.Checked ) return;
      if ( DataGridViewUsers.SelectedRows.Count == 0 ) return;
      EditSearch.Text = (string)DataGridViewUsers.SelectedRows[0].Cells[0].Value;
    }

    private void EditSearchInRecipients_CheckedChanged(object sender, EventArgs e)
    {
      if ( !EditSearchInRecipients.Checked && !EditSearchInMessage.Checked )
      {
        EditSearchInRecipients.Checked = true;
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
      if ( modified ) TweetsControl_OnModified(null, null);
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

    private void ShowUsers(string title, List<User> users)
    {
      var items = users.Select((user, index) => $"{index + 1}. {user.ScreenName} : {user.Name} - {user.Description.Replace(Environment.NewLine, " | ").Replace("\n", " | ")}");
      string text = title + " " + DateTime.Today.ToString("yyyy.MM.dd") + Environment.NewLine +
                    Environment.NewLine +
                    string.Join(Environment.NewLine, items);
      EditUsers.Text = text;
      //new ShowTextForm(title, text, width: 1000, height: 1000, wrap: false).ShowDialog();
    }

    private void ProcessWithLoadingForm(object sender, Action<List<User>, Action<int>> action)
    {
      if ( !IsConnected(true) ) return;
      var tempProgressBar = LoadingForm.Instance.ProgressBar.Style;
      var tempLabelCount = LoadingForm.Instance.LabelCount.Visible;
      string title = ( sender as Control )?.Text ?? "Users";
      LoadingForm.Instance.Initialize($"Reading {title}...", 10, 0, false, canCancel: true);
      LoadingForm.Instance.ProgressBar.Style = ProgressBarStyle.Marquee;
      LoadingForm.Instance.LabelCount.Visible = true;
      var users = new List<User>();
      int total = 0;
      SystemManager.TryCatchManage(ShowExceptionMode.OnlyMessage, () => action(users, quanta =>
      {
        if ( LoadingForm.Instance.CancelRequired ) throw new AbortException();
        LoadingForm.Instance.LabelCount.Text = total.ToString();
        LoadingForm.Instance.Refresh();
        total += quanta;
      }));
      ShowUsers(title, users);
      LoadingForm.Instance.LabelCount.Visible = tempLabelCount;
      LoadingForm.Instance.ProgressBar.Style = tempProgressBar;
      LoadingForm.Instance.Close();
    }

    private void ActionGetFollowers_Click(object sender, EventArgs e)
    {
      ProcessWithLoadingForm(sender, (users, callback) =>
      {
        long? cursor = null;
        int quanta = APIStep;
        int count = quanta;
        while ( count == quanta )
        {
          callback(quanta);
          var list = Tokens.Followers.List(Tokens.UserId, count: APIStep, cursor: cursor);
          cursor = list.NextCursor;
          count = list.Count;
          users.AddRange(list.ToList());
          Thread.Sleep(ListTweets.LimitDelay * 2);
        }
      });
    }

    private void ActionGetFellowing_Click(object sender, EventArgs e)
    {
      ProcessWithLoadingForm(sender, (users, callback) =>
      {
        long? cursor = null;
        int quanta = APIStep;
        int count = quanta;
        while ( count == quanta )
        {
          callback(quanta);
          var list = Tokens.Friends.List(Tokens.UserId, count: APIStep, cursor: cursor);
          cursor = list.NextCursor;
          count = list.Count;
          users.AddRange(list.ToList());
          Thread.Sleep(ListTweets.LimitDelay * 2);
        }
      });
    }

    private void ActionGetMutes_Click(object sender, EventArgs e)
    {
      ProcessWithLoadingForm(sender, (users, callback) =>
      {
        long? cursor = null;
        int quanta = 20;
        int count = quanta;
        while ( count == quanta )
        {
          callback(quanta);
          var list = Tokens.Mutes.Users.List(cursor: cursor);
          cursor = list.NextCursor;
          count = list.Count;
          users.AddRange(list.ToList());
          Thread.Sleep(ListTweets.LimitDelay * 5);
        }
      });
    }

    private void ActionGetBlocks_Click(object sender, EventArgs e)
    {
      ProcessWithLoadingForm(sender, (users, callback) =>
      {
        long? cursor = null;
        int quanta = 20;
        int count = quanta;
        while ( count == 20 )
        {
          callback(quanta);
          var list = Tokens.Blocks.List(cursor: cursor);
          cursor = list.NextCursor;
          count = list.Count;
          users.AddRange(list.ToList());
          Thread.Sleep(ListTweets.LimitDelay * 5);
        }
      });
    }

    private void ActionGetLikes_Click(object sender, EventArgs e)
    {
      /*if ( !IsConnected(true) ) return;
      var list = Tokens.Favorites.List(Tokens.UserId, count: 200);
      foreach ( var item in list )
      {
        if ( item.User.ScreenName.ToLower().Contains("") )
          ;
      }*/
    }

  }

}
