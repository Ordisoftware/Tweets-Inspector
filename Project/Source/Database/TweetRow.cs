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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Tweets.Inspector;

using SQLite;

[Serializable]
[Table("Tweets")]
public class TweetRow : AbstractRow
{

  [NotNull]
  public DateTime Date
  {
    get => _Date;
    set
    {
      if ( _Date == value ) return;
      _Date = value;
      NotifyPropertyChanged(nameof(Date));
    }
  }
  private DateTime _Date = DateTime.MinValue;

  [NotNull]
  public TweetType Type
  {
    get => _Type;
    set
    {
      if ( _Type == value ) return;
      _Type = value;
      NotifyPropertyChanged(nameof(Type));
    }
  }
  private TweetType _Type = TweetType.Main;

  [NotNull]
  public string Recipients
  {
    get => _Recipients;
    set
    {
      if ( _Recipients == value ) return;
      _Recipients = value;
      NotifyPropertyChanged(nameof(Recipients));
    }
  }
  private string _Recipients = string.Empty;

  [NotNull]
  public string Message
  {
    get => _Message;
    set
    {
      if ( _Message == value ) return;
      _Message = value;
      NotifyPropertyChanged(nameof(Message));
    }
  }
  private string _Message = string.Empty;

  public string ScreenName
    => MainForm.Tokens?.ScreenName.IsNullOrEmpty() != false
       ? "ordisoftware"
       : MainForm.Tokens.ScreenName;

  public List<string> RecipientsAsList => Recipients.Split(',').ToList();

  public string Url => $"https://twitter.com/{ScreenName}/status/{Id}";

  public override string ToString()
    => $"{Id}; {Date}; {Recipients}; {Message}; {Url}";

}
