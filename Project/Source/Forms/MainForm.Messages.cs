using System;
using System.Text;
using System.Windows.Forms;

namespace Ordisoftware.TwitterManager
{

  public partial class MainForm
  {

    private void DoOpenMessages()
    {
      //if ( OpenFileDialog.ShowDialog() != DialogResult.OK ) return;
      //var lines = File.ReadAllLines(OpenFileDialog.FileName);
      var lines = EditMessagesSource.Lines;
      var result = new StringBuilder();
      string user = "";
      for ( int index = 0; index < lines.Length; index++ )
      {
        string line = lines[index].Trim();
        if ( line == "" || line.Contains("il y a") ) continue;
        if ( line == EditUser1.Text || line == EditUser2.Text )
        {
          user = line;
          continue;
        }
        result.AppendLine(user + "|" + line);
      }
      EditMessagesCleaned.Text = result.ToString();
    }
    
  }

}
