using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TwitterManager
{

  public partial class SearchResultForm : Form
  {

    static public void Run(IEnumerable<Tweet> tweets)
    {
      var form = new SearchResultForm();
      form.TweetsControl.Populate(tweets);
      form.ShowDialog();
    }

    private SearchResultForm()
    {
      InitializeComponent();
    }

  }

}
