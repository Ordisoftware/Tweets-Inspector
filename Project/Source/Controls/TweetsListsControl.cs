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
namespace Ordisoftware.TweetsInspector;

public partial class TweetsControl : UserControl
{

  static internal readonly string FilterMain = "Type = " + (int)TweetType.Main;
  static internal readonly string FilterReplies = "Type = " + (int)TweetType.Reply;
  static internal readonly string FilterRTs = "Type = " + (int)TweetType.RT;

  public event EventHandler Modified;

  public TweetsControl()
  {
    InitializeComponent();
    MinimumSize = ListTweetsMain.MinimumSize;
    ListTweetsMain.LabelTitle.Text = "TWEETS";
    ListTweetsReplies.LabelTitle.Text = "REPLIES";
    ListTweetsRTs.LabelTitle.Text = "RETWEETS";
    ListTweetsMain.DefaultFilter = FilterMain;
    ListTweetsReplies.DefaultFilter = FilterReplies;
    ListTweetsRTs.DefaultFilter = FilterRTs;
    ListTweetsMain.Modified += Modified;
    ListTweetsReplies.Modified += Modified;
    ListTweetsRTs.Modified += Modified;
  }

  public void RefreshFilters()
  {
    ListTweetsMain.RefreshFilter();
    ListTweetsReplies.RefreshFilter();
    ListTweetsRTs.RefreshFilter();
  }

  public void SelectAll()
  {
    ListTweetsMain.ActionSelectAll.PerformClick();
    ListTweetsReplies.ActionSelectAll.PerformClick();
    ListTweetsRTs.ActionSelectAll.PerformClick();
  }

  public void SelectNone()
  {
    ListTweetsMain.ActionSelectNone.PerformClick();
    ListTweetsReplies.ActionSelectNone.PerformClick();
    ListTweetsRTs.ActionSelectNone.PerformClick();
  }

  public void DeleteSelected()
  {
    ListTweetsMain.ActionDelete.PerformClick();
    ListTweetsReplies.ActionDelete.PerformClick();
    ListTweetsRTs.ActionDelete.PerformClick();
  }

  public void SetSearchTerm(string term)
  {
    ListTweetsMain.EditFilter.Text = term;
    ListTweetsReplies.EditFilter.Text = term;
    ListTweetsRTs.EditFilter.Text = term;
  }

}
