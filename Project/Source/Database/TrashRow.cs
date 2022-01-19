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
/// <edited> 2022-01 </edited>
namespace Ordisoftware.TweetsInspector;

using SQLite;

[Serializable]
[Table("Trash")]
public class TrashRow : TweetRow
{

  [NotNull]
  public DateTime DateDeleted
  {
    get => _DateDeleted;
    set
    {
      if ( _DateDeleted == value ) return;
      _DateDeleted = value;
      NotifyPropertyChanged(nameof(DateDeleted));
    }
  }
  private DateTime _DateDeleted = DateTime.MinValue;

}
