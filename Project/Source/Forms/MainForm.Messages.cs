﻿/// <license>
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