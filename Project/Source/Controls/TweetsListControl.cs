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
using System.Linq;
using System.Data.Odbc;
using System.Windows.Forms;
using Ordisoftware.Core;
using System.Threading;
using System.ComponentModel;

namespace Ordisoftware.TwitterManager
{

  public partial class ListTweets : UserControl
  {

    public bool Modified { get; private set; }

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
      System.Diagnostics.Process.Start(( (Tweet)DataGridView.CurrentCell.OwningRow.DataBoundItem ).Url);
    }

    private void ActionTweetOpen_Click(object sender, EventArgs e)
    {
      foreach ( DataGridViewRow row in DataGridView.SelectedRows )
      {
        System.Diagnostics.Process.Start(( (Tweet)row.DataBoundItem ).Url);
        Thread.Sleep(2000);
      }
    }

    private void ActionTweetDelete_Click(object sender, EventArgs e)
    {
      if ( !Properties.Settings.Default.DeleteOnlyLocalMode && MainForm.TwitterTokens == null )
      {
        DisplayManager.ShowWarning("Not connected.");
        return;
      }
      var list = DataGridView.SelectedRows.Cast<DataGridViewRow>().Select(row => (Tweet)row.DataBoundItem).ToList();
      var ids = list.Select(tweet => tweet.Id).ToList();
      string str = ids.Count > 10
                   ? string.Join(Globals.NL, ids.Take(10)) + Globals.NL + "..."
                   : string.Join(Globals.NL, ids);
      if ( !DisplayManager.QueryYesNo("Delete Tweet(s) ?" + Globals.NL2 + str) ) return;
      foreach ( var tweet in list )
      {
        long id = tweet.Id;
        if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
          MainForm.TwitterTokens.Statuses.Destroy(id);
        ((BindingList<Tweet>)DataGridView.DataSource).Remove(tweet);
        MainForm.Tweets.Remove(tweet);
        var command = new OdbcCommand("DELETE FROM Tweets WHERE Id = ?", MainForm.LockFileConnection);
        command.Parameters.Add("@Id", OdbcType.BigInt).Value = id;
        command.ExecuteNonQuery();
      }
      Modified = true;
    }

  }

}
