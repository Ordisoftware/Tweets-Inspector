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
