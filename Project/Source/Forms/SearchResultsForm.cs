using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TwitterManager
{

  public partial class SearchResultForm : Form
  {

    static public bool Run(IEnumerable<Tweet> tweets)
    {
      var form = new SearchResultForm();
      form.TweetsControl.Populate(tweets);
      form.ShowDialog();
      return form.TweetsControl.Modified;
    }

    private SearchResultForm()
    {
      InitializeComponent();
    }

  }

}
