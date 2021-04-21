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
using Ordisoftware.Core;

namespace Ordisoftware.TwitterManager
{

  public enum TweetType { Main, Reply, RT };

  public class Tweet
  {
    public string ScreenName => MainForm.TwitterTokens == null || MainForm.TwitterTokens.ScreenName.IsNullOrEmpty()
                                ? "ordisoftware"
                                : MainForm.TwitterTokens.ScreenName;
    public TweetType Type { get; set; }
    public long Id { get; set; }
    public string Date { get; set; }
    public string Message { get; set; }
    public string Recipients { get; set; }
    public List<string> RecipientsAsList => Recipients.Split(',').ToList();
    public string Url => $"https://twitter.com/{ScreenName}/status/{Id}";
    public override string ToString()
    {
      return $"{Id}; {Date}; {string.Join(", ", Recipients)}; {Message}; {Url}";
    }
  }

}
