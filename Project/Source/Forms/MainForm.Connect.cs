﻿/// <license>
/// This file is part of Ordisoftware Tweets Inspector.
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
using System.Threading.Tasks;
using CoreTweet;
using Ordisoftware.Core;

namespace Ordisoftware.TweetsInspector
{

  public partial class MainForm
  {

    private const string OAuthVerifierTag = "oauth_verifier";

    private async void DoConnect()
    {
      if ( IsConnected(false) ) return;
      if ( Settings.ConsumerKey == "" || Settings.ConsumerSecret == "" || Settings.ConsumerBackUrl == "" ) return;
      Enabled = false;
      try
      {
        bool done = false;
        bool cancelled = false;
        Session = OAuth.Authorize(Settings.ConsumerKey, Settings.ConsumerSecret, Settings.ConsumerBackUrl);
        var form = new WebBrowserForm();
        form.FormClosed += (_s, _e) => cancelled = !done;
        form.WebBrowser.AddressChanged += (_s, _e) => done |= _e.Address.Contains(Settings.ConsumerBackUrl);
        form.WebBrowser.Load(Session.AuthorizeUri.AbsoluteUri);
        form.Show();
        while ( !done && !cancelled ) await Task.Delay(100);
        if ( form.Visible ) form.Close();
        this.ForceBringToFront();
        Enabled = true;
        if ( cancelled ) return;
        var items = form.WebBrowser.Address.SplitNoEmptyLines($"&{OAuthVerifierTag}=");
        if ( items.Length == 2 && items[1].Trim() != "" )
        {
          Tokens = Session.GetTokens(items[1]);
          Text = $"{Globals.AssemblyTitle} - Connected @{Tokens.ScreenName}";
          ActionConnect.Enabled = false;
        }
        else
          DisplayManager.ShowWarning($"Tag not found : {OAuthVerifierTag}");
      }
      finally
      {
        Enabled = true;
      }
    }

  }

}