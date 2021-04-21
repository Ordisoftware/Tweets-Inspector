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
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace Ordisoftware.TwitterManager
{

  public partial class TweetsControl : UserControl
  {

    public bool Modified => ListTweetsMain.Modified || ListTweetsReplies.Modified || ListTweetsRTs.Modified;

    public TweetsControl()
    {
      InitializeComponent();
    }

    public void Populate(IEnumerable<Tweet> tweets)
    {
      ListTweetsMain.DataGridView.DataSource = select(TweetType.Main);
      ListTweetsReplies.DataGridView.DataSource = select(TweetType.Reply);
      ListTweetsRTs.DataGridView.DataSource = select(TweetType.RT);
      //
      BindingList<Tweet> select(TweetType type) => new BindingList<Tweet>(tweets.Where(t => t.Type == type).ToList());
    }

  }

}
