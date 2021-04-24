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
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.Core;
using System.Threading;

namespace Ordisoftware.TweetsInspector
{

  public partial class ListTweets : UserControl
  {

    static public int ConfirmDeleteMaxIdsToShow = 10;
    static public int ConfirmOpenMaxIds = 5;
    static public int OpenMaxIds = 20;
    static public int OpenDelay = 1000;

    public event EventHandler Modified;

    public string DefaultFilter { get; set; }

    public object DataSource
    {
      get => DataGridView.DataSource;
      set
      {
        DataGridView.DataSource = value;
        if ( value != null )
          DataGridView.Sort(ColumnDate, System.ComponentModel.ListSortDirection.Ascending);
      }
    }

    public ListTweets()
    {
      InitializeComponent();
    }

    private void ActionSelectAll_Click(object sender, EventArgs e)
    {
      DataGridView.SelectAll();
    }

    private void ActionSelectNone_Click(object sender, EventArgs e)
    {
      DataGridView.ClearSelection();
    }

    public void RefreshFilter()
    {
      EditFilter_TextChanged(EditFilter, EventArgs.Empty);
    }

    private void ActionFilterClear_Click(object sender, EventArgs e)
    {
      ( DataGridView.DataSource as BindingSource ).Filter = DefaultFilter;
    }

    private void EditFilter_TextChanged(object sender, EventArgs e)
    {
      var ds = DataGridView.DataSource as BindingSource;
      ds.Filter = DefaultFilter;
      if ( EditFilter.Text != "" )
      {
        if ( MainForm.Instance.EditSearchUser.Checked && MainForm.Instance.EditSearchInMessage.Checked )
          ds.Filter += $" AND ( Recipients LIKE '*{EditFilter.Text}*' OR Message LIKE '*{EditFilter.Text}*' )";
        else
        if ( MainForm.Instance.EditSearchUser.Checked )
          ds.Filter += $" AND Recipients LIKE '*{EditFilter.Text}*'";
        else
          ds.Filter += $" AND Message LIKE '*{EditFilter.Text}*";
      }
      DataGridView.ClearSelection();
    }

    private Data.DataSet.TweetsRow GetTweetRow(DataGridViewRow row)
    {
      return (Data.DataSet.TweetsRow)( (DataRowView)row.DataBoundItem ).Row;
    }

    private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      OpenTweet(DataGridView.CurrentRow);
    }

    private void DataGridView_MouseDown(object sender, MouseEventArgs e)
    {
      if ( e.Button == MouseButtons.Right )
      {
        var hit = DataGridView.HitTest(e.X, e.Y);
        var row = DataGridView.Rows[hit.RowIndex];
        if ( !row.Selected )
        {
          DataGridView.ClearSelection();
          row.Selected = true;
        }
      }
    }

    private void OpenTweet(DataGridViewRow row, bool delay = false)
    {
      System.Diagnostics.Process.Start(GetTweetRow(row).Url);
      if ( delay ) Thread.Sleep(OpenDelay);
    }

    private void ActionOpen_Click(object sender, EventArgs e)
    {
      int count = DataGridView.SelectedRows.Count;
      if ( count > OpenMaxIds )
      {
        DisplayManager.Show($"Too many tweets to open : {count}");
        return;
      }
      else
      if ( count >= ConfirmOpenMaxIds )
        if ( !DisplayManager.QueryYesNo($"Open {count} Tweet(s) ?") ) return;
      foreach ( DataGridViewRow item in DataGridView.SelectedRows )
        OpenTweet(item, true);
    }

    private void ActionDelete_Click(object sender, EventArgs e)
    {
      if ( DataGridView.SelectedRows.Count == 0 ) return;
      if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
        if ( !MainForm.IsConnected(true) ) return;
      var listRows = DataGridView.SelectedRows
                                 .Cast<DataGridViewRow>()
                                 .Select(item => GetTweetRow(item))
                                 .ToList();
      var listIds = listRows.Select(tweet => tweet.Id).ToList();
      string msg = listIds.Count > ConfirmDeleteMaxIdsToShow
                   ? string.Join(Globals.NL, listIds.Take(ConfirmDeleteMaxIdsToShow)) + Globals.NL + "..."
                   : string.Join(Globals.NL, listIds);
      if ( !DisplayManager.QueryYesNo($"Delete {listRows.Count} {LabelTitle.Text} ?" + Globals.NL2 + msg) )
        return;
      if ( listRows.Count > 2 )
      {
        Cursor = Cursors.WaitCursor;
        Enabled = false;
        LoadingForm.Instance.Initialize("Deleting...", listRows.Count);
      }
      try
      {
        foreach ( var tweet in listRows )
        {
          LoadingForm.Instance.DoProgress();
          if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
            SystemManager.TryCatch(() => MainForm.Tokens.Statuses.Destroy(long.Parse(tweet.Id)));
          else
            if ( !DisplayManager.QueryYesNo("Tweets will be deleted in the database but not in Twitter. Continue?") )
              return;
          tweet.Delete();
        }
        Modified?.Invoke(this, EventArgs.Empty);
      }
      finally
      {
        if ( !Enabled )
        {
          Enabled = true;
          Cursor = Cursors.Default;
          LoadingForm.Instance.Hide();
        }
      }
      MainForm.Instance.TableAdapterManager.UpdateAll(MainForm.Instance.DataSet);
    }

  }

}
