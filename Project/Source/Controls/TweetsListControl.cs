using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Ordisoftware.Core;
using System.Threading;

namespace TwitterManager
{

  public partial class ListTweets : UserControl
  {

    private ListViewColumnSorter ColumnSorter;

    public bool Modified { get; private set; }

    public ListTweets()
    {
      InitializeComponent();
      ColumnSorter = new ListViewColumnSorter();
      ListView.ListViewItemSorter = ColumnSorter;
    }

    public void Populate(IEnumerable<Tweet> tweets)
    {
      ListView.Items.Clear();
      foreach ( var tweet in tweets )
      {
        var item = new ListViewItem();
        item.Tag = tweet;
        item.Text = tweet.Id;
        item.SubItems.Add(tweet.Date);
        item.SubItems.Add(string.Join(", ", tweet.Recipients));
        item.SubItems.Add(tweet.Message);
        ListView.Items.Add(item);
      }
    }

    public void SearchAndSelect(string term)
    {
      ListView.SelectedItems.Clear();
      foreach ( ListViewItem item in ListView.Items )
        if ( item.SubItems[0].Text == term
          || item.SubItems[2].Text.Contains(term)
          || item.SubItems[3].Text.Contains(term) )
        {
          item.Selected = true;
          item.EnsureVisible();
        }
    }

    private void ListView_SizeChanged(object sender, EventArgs e)
    {
      ColumnMessage.Width = -2;
    }

    private void ListView_DoubleClick(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(( (Tweet)( ListView.FocusedItem ).Tag ).Url);
    }

    private void ActionTweetOpen_Click(object sender, EventArgs e)
    {
      foreach ( var item in ListView.SelectedItems )
      {
        System.Diagnostics.Process.Start(( (Tweet)( (ListViewItem)item ).Tag ).Url);
        Thread.Sleep(2000);
      }
    }

    private void ActionTweetDelete_Click(object sender, EventArgs e)
    {
      if ( MainForm.TwitterTokens == null )
      {
        DisplayManager.ShowWarning("Not connected.");
        return;
      }
      var list = ListView.SelectedItems.Cast<ListViewItem>().ToList();
      var ids = list.Select(item => ( (Tweet)item.Tag ).Id).ToList();
      if ( !DisplayManager.QueryYesNo("Delete Tweet(s) ?" + Globals.NL2 + string.Join(Globals.NL, list)) ) return;
      foreach ( ListViewItem item in ListView.SelectedItems )
      {
        MainForm.TwitterTokens.Statuses.Destroy(long.Parse(( (Tweet)item.Tag ).Id));
        ListView.Items.Remove(item);
      }
      Modified = true;
    }

    private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      if ( e.Column == ColumnSorter.SortColumn )
        if ( ColumnSorter.Order == SortOrder.Ascending )
          ColumnSorter.Order = SortOrder.Descending;
        else
          ColumnSorter.Order = SortOrder.Ascending;
      else
      {
        ColumnSorter.SortColumn = e.Column;
        ColumnSorter.Order = SortOrder.Ascending;
      }
      ListView.Sort();
    }

    private class ListViewColumnSorter : IComparer
    {
      private CaseInsensitiveComparer Comparer;
      public int SortColumn { set; get; }
      public SortOrder Order { set; get; }
      public ListViewColumnSorter()
      {
        SortColumn = 0;
        Order = SortOrder.None;
        Comparer = new CaseInsensitiveComparer();
      }
      public int Compare(object x, object y)
      {
        int compareResult;
        ListViewItem listviewX, listviewY;
        listviewX = (ListViewItem)x;
        listviewY = (ListViewItem)y;
        compareResult = Comparer.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);
        return Order == SortOrder.Ascending
               ? compareResult
               : Order == SortOrder.Descending
                 ? -compareResult
                 : 0;
      }
    }

  }

}
