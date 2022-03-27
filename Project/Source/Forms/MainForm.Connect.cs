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
namespace Ordisoftware.Tweets.Inspector;

using CoreTweet;
using Ordisoftware.Core;

public partial class MainForm
{

  private const string OAuthVerifierTag = "oauth_verifier";

  private async void DoConnectAsync()
  {
    if ( IsConnected(false) ) return;
    if ( Settings.ConsumerKey.IsNullOrEmpty()
      || Settings.ConsumerSecret.IsNullOrEmpty()
      || Settings.ConsumerBackUrl.IsNullOrEmpty() ) return;
    Enabled = false;
    try
    {
      bool done = false;
      bool cancelled = false;
#pragma warning disable PH_S019 // Blocking Method in Async Method - N/A
#pragma warning disable MA0042 // Do not use blocking calls in an async method - N/A
      Session = OAuth.Authorize(Settings.ConsumerKey, Settings.ConsumerSecret, Settings.ConsumerBackUrl);
#pragma warning restore MA0042 // Do not use blocking calls in an async method
#pragma warning restore PH_S019 // Blocking Method in Async Method
      var form = new WebBrowserForm();
      form.FormClosed += (_s, _e) => cancelled = !done;
      form.WebBrowser.AddressChanged += (_s, _e) => done |= _e.Address.Contains(Settings.ConsumerBackUrl);
      form.WebBrowser.Load(Session.AuthorizeUri.AbsoluteUri);
      form.Show();
      while ( !done && !cancelled ) await Task.Delay(100).ConfigureAwait(false);
      form.SyncUI(() =>
      {
        if ( form.Visible )
          form.Close();
        this.ForceBringToFront();
        Enabled = true;
        if ( cancelled ) return;
        var items = form.WebBrowser.Address.SplitNoEmptyLines($"&{OAuthVerifierTag}=");
        if ( items.Length == 2 && items[1].Trim().Length != 0 )
        {
          Tokens = Session.GetTokens(items[1]);
          Text = $"{Globals.AssemblyTitle} - Connected @{Tokens.ScreenName}";
          ActionConnect.Enabled = false;
        }
        else
          DisplayManager.ShowWarning($"Tag not found : {OAuthVerifierTag}");
      });
    }
    finally
    {
      Enabled = true;
    }
  }

}
