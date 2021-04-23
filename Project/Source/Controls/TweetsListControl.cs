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
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.Core;
using System.Threading;

namespace Ordisoftware.TwitterManager
{

  public partial class ListTweets : UserControl
  {

    public event EventHandler Modified;

    public string DefaultFilter { get; set; }

    public object DataSource
    {
      get => DataGridView.DataSource;
      set => DataGridView.DataSource = value;
    }

    public ListTweets()
    {
      InitializeComponent();
    }

    public void SearchAndSelect(string term)
    {
      DataGridView.SelectedRows.Clear();
      foreach ( DataGridViewRow row in DataGridView.Rows )
        if ( ( row.Cells[ColumnId.Index].Value as string ) == term
          || ( row.Cells[ColumnRecipients.Index].Value as string ).Contains(term)
          || ( row.Cells[ColumnMessage.Index].Value as string ).Contains(term) )
          row.Selected = true;
      if ( DataGridView.SelectedRows.Count > 0 )
        DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.SelectedRows[0].Index;
    }

    private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var row = ( (DataRowView)DataGridView.CurrentRow.DataBoundItem ).Row;
      string url = ( (Data.DataSet.TweetsRow)row ).Url;
      System.Diagnostics.Process.Start(url);
    }

    private void ActionTweetOpen_Click(object sender, EventArgs e)
    {
      int count = DataGridView.SelectedRows.Count;
      if ( count > 10 )
      {
        DisplayManager.Show($"Too many tweets to open : {count}");
        return;
      }
      else
      if ( count > 4 )
        if ( !DisplayManager.QueryYesNo($"Open {count} Tweet(s) ?") ) return;
      foreach ( DataGridViewRow item in DataGridView.SelectedRows )
      {
        var row = ( (DataRowView)item.DataBoundItem ).Row;
        string url = ( (Data.DataSet.TweetsRow)row ).Url;
        System.Diagnostics.Process.Start(url);
        Thread.Sleep(1000);
      }
    }

    private void ActionTweetDelete_Click(object sender, EventArgs e)
    {
      if ( DataGridView.SelectedRows.Count == 0 ) return;
      if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
        if ( !MainForm.IsConnected(true) ) return;
      var list = DataGridView.SelectedRows
                             .Cast<DataGridViewRow>()
                             .Select(item => (Data.DataSet.TweetsRow)( (DataRowView)item.DataBoundItem ).Row)
                             .ToList();
      var ids = list.Select(tweet => tweet.Id).ToList();
      string str = ids.Count > 10
                   ? string.Join(Globals.NL, ids.Take(10)) + Globals.NL + "..."
                   : string.Join(Globals.NL, ids);
      if ( !DisplayManager.QueryYesNo($"Delete {list.Count} {LabelTitle.Text} ?" + Globals.NL2 + str) ) return;
      if ( list.Count > 2 )
      {
        Cursor = Cursors.WaitCursor;
        Enabled = false;
        LoadingForm.Instance.Initialize("Deleting...", list.Count);
      }
      try
      {
        foreach ( var tweet in list )
        {
          LoadingForm.Instance.DoProgress();
          long id = long.Parse(tweet.Id);
          if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
            try
            {
              var res = MainForm.TwitterTokens.Statuses.Destroy(id);
            }
            catch
            {
            }
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

    private void ActionSelectAll_Click(object sender, EventArgs e)
    {
      DataGridView.SelectAll();
    }

    private void ActionSelectNone_Click(object sender, EventArgs e)
    {
      DataGridView.ClearSelection();
    }

    private void ActionFilterClear_Click(object sender, EventArgs e)
    {
      var ds = DataGridView.DataSource as BindingSource;
      ds.Filter = DefaultFilter;
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

    public void RefreshFilter()
    {
      EditFilter_TextChanged(EditFilter, EventArgs.Empty);
    }

  }

}
