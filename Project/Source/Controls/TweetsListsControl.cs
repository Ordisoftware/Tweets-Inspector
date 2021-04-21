using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TwitterManager
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
      ListTweetsMain.Populate(tweets.Where(t => t.Type == TweetType.Main));
      ListTweetsReplies.Populate(tweets.Where(t => t.Type == TweetType.Reply));
      ListTweetsRTs.Populate(tweets.Where(t => t.Type == TweetType.RT));
    }

  }

}
