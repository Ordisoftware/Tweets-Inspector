/// <license>
/// This file is part of Ordisoftware Tweets Inspector.
/// Copyright 2021-2022 Olivier Rogier.
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
namespace Ordisoftware.Tweets.Inspector;

using CoreTweet;
using Equin.ApplicationFramework;

public partial class ListTweets : UserControl
{

  public const int ConfirmDeleteMaxIdsToShow = 10;
  public const int ConfirmOpenMaxIds = 5;
  public const int OpenMaxIds = 20;
  public const int LimitDelay = 1000;

  public event EventHandler Modified;

  public string Title
  {
    get => LabelTitle.Text;
    set => LabelTitle.Text = value;
  }

  public string DefaultFilter { get; set; }

  public object DataSource
  {
    get => DataGridView.DataSource;
    set
    {
      DataGridView.DataSource = value;
      if ( value is not null )
        DataGridView.Sort(ColumnDate, ListSortDirection.Ascending);
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
    EditFilter.Text = "";
    var source = DataGridView.DataSource as BindingSource;
    if ( source is not null ) source.Filter = DefaultFilter;
  }

  private void EditFilter_TextChanged(object sender, EventArgs e)
  {
    //var ds = DataGridView.DataSource as BindingSource;
    //if ( EditFilter.Text != "" )
    //{
    //  string filter = DefaultFilter.IsNullOrEmpty() ? "" : $"{DefaultFilter} AND";
    //  if ( MainForm.Instance.EditSearchInRecipients.Checked && MainForm.Instance.EditSearchInMessage.Checked )
    //    ds.Filter = $"{filter} ( Recipients LIKE '*{EditFilter.Text}*' OR Message LIKE '*{EditFilter.Text}*' )";
    //  else
    //  if ( MainForm.Instance.EditSearchInRecipients.Checked )
    //    ds.Filter = $"{filter} Recipients LIKE '*{EditFilter.Text}*'";
    //  else
    //    ds.Filter = $"{filter} Message LIKE '*{EditFilter.Text}*'";
    //}
    //else
    //  ds.Filter = DefaultFilter;
    //DataGridView.ClearSelection();
  }

  private TweetRow GetTweetRow(DataGridViewRow row)
  {
    return ( (ObjectView<TweetRow>)row.DataBoundItem ).Object;
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
    SystemManager.RunShell(GetTweetRow(row).Url);
    if ( delay ) Thread.Sleep(LimitDelay);
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
    bool delay = false;
    if ( DataGridView.SelectedRows.Count == 0 ) return;
    if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
      if ( !MainForm.IsConnected(true) ) return;
    var listRows = DataGridView.SelectedRows
                               .Cast<DataGridViewRow>()
                               .Select(item => GetTweetRow(item))
                               .ToList();
    var listIds = listRows.ConvertAll(tweet => tweet.Id);
    string msg = listIds.Count > ConfirmDeleteMaxIdsToShow
                 ? listIds.Take(ConfirmDeleteMaxIdsToShow).AsMultiLine() + Globals.NL + "..."
                 : listIds.AsMultiLine();
    if ( !DisplayManager.QueryYesNo($"Delete {listRows.Count} {LabelTitle.Text} ?{Globals.NL2}{msg}") )
      return;
    if ( Properties.Settings.Default.DeleteOnlyLocalMode )
      if ( !DisplayManager.QueryYesNo("Tweets will be deleted in the database but not in Twitter. Continue?") )
        return;
    if ( listRows.Count > 2 )
    {
      delay = true;
      Cursor = Cursors.WaitCursor;
      Enabled = false;
      Parent.Enabled = false;
      ParentForm.Enabled = false;
      LoadingForm.Instance.Initialize("Deleting...", listRows.Count, 0, false, showCounter: true, canCancel: true);
      LoadingForm.Instance.TopMost = false;
    }
    try
    {
      foreach ( var tweet in listRows )
      {
        LoadingForm.Instance.DoProgress();
        if ( LoadingForm.Instance.CancelRequired ) break;
        if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
          try
          {
            if ( delay ) Thread.Sleep(LimitDelay);
            MainForm.Tokens.Statuses.Destroy(long.Parse(tweet.Id));
            ApplicationDatabase.Instance.Connection.Delete(tweet);
            ApplicationDatabase.Instance.Tweets.Remove(tweet);
          }
          catch ( TwitterException ex )
          {
            if ( ex.Status == HttpStatusCode.NotFound )
            {
              ApplicationDatabase.Instance.Connection.Delete(tweet);
              ApplicationDatabase.Instance.Tweets.Remove(tweet);
            }
            else
              ex.Manage();
          }
          catch ( Exception ex )
          {
            ex.Manage();
          }
      }
      Modified?.Invoke(this, EventArgs.Empty);
    }
    finally
    {
      if ( !Enabled )
      {
        Enabled = true;
        Parent.Enabled = true;
        ParentForm.Enabled = true;
        Cursor = Cursors.Default;
        LoadingForm.Instance.Hide();
      }
    }
  }

  // TODO move to trash on delete

  private void CheckOnlineToolStripMenuItem_Click(object sender, EventArgs e)
  {
    bool delay = false;
    int count = 0;
    if ( DataGridView.SelectedRows.Count == 0 ) return;
    if ( !MainForm.IsConnected(true) ) return;
    var listRows = DataGridView.SelectedRows
                               .Cast<DataGridViewRow>()
                               .Select(item => GetTweetRow(item))
                               .ToList();
    if ( listRows.Count > 2 )
    {
      delay = true;
      Cursor = Cursors.WaitCursor;
      Enabled = false;
      Parent.Enabled = false;
      ParentForm.Enabled = false;
      LoadingForm.Instance.Initialize("Checking to delete...", listRows.Count, 0, false, showCounter: true, canCancel: true);
      LoadingForm.Instance.TopMost = false;
    }
    try
    {
      foreach ( var tweet in listRows )
      {
        LoadingForm.Instance.DoProgress();
        if ( LoadingForm.Instance.CancelRequired ) break;
        if ( !Properties.Settings.Default.DeleteOnlyLocalMode )
          try
          {
            if ( delay ) Thread.Sleep(LimitDelay);
            MainForm.Tokens.Statuses.Show(long.Parse(tweet.Id));
          }
          catch ( TwitterException ex )
          {
            if ( ex.Status == HttpStatusCode.NotFound )
            {
              ApplicationDatabase.Instance.Connection.Delete(tweet);
              ApplicationDatabase.Instance.Tweets.Remove(tweet);
              count++;
            }
            else
              ex.Manage();
          }
          catch ( Exception ex )
          {
            ex.Manage();
          }
      }
      Modified?.Invoke(this, EventArgs.Empty);
    }
    finally
    {
      if ( !Enabled )
      {
        Enabled = true;
        Parent.Enabled = true;
        ParentForm.Enabled = true;
        Cursor = Cursors.Default;
        LoadingForm.Instance.Hide();
      }
    }
    DisplayManager.Show($"Deleted tweets: {count}");
  }

}
