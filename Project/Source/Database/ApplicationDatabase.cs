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

using Equin.ApplicationFramework;

class ApplicationDatabase : SQLiteDatabase
{

  static public readonly string TweetsTableName = nameof(Tweets);

  static public ApplicationDatabase Instance { get; protected set; }

  static ApplicationDatabase()
  {
    Instance = new ApplicationDatabase();
  }

  public List<TweetRow> Tweets { get; private set; }

  public BindingListView<TweetRow> TweetsMainAsBindingList { get; private set; }
  public BindingListView<TweetRow> TweetsRepliesAsBindingList { get; private set; }
  public BindingListView<TweetRow> TweetsRTsAsBindingList { get; private set; }

  private ApplicationDatabase() : base(Globals.ApplicationDatabaseFilePath)
  {
  }

  protected override void Vacuum(bool force = false)
  {
    var settings = Program.Settings;
    if ( settings.VacuumAtStartup || force )
    {
      var dateNew = Connection.Optimize(settings.VacuumLastDone, settings.VacuumAtStartupDaysInterval, force);
      if ( settings.VacuumLastDone != dateNew )
        settings.VacuumLastDone = dateNew;
    }
  }

  protected override void DoClose()
  {
    if ( Tweets is null ) return;
    if ( ClearListsOnCloseOrRelease ) Tweets?.Clear();
    Tweets = null;
  }

  protected override void CreateTables()
  {
    Connection.CreateTable<TweetRow>();
  }

  protected override void DoLoadAll()
  {
    OnLoadingData(SysTranslations.LoadingData.GetLang());
    Tweets = new(Connection.Table<TweetRow>());
    OnDataLoaded(SysTranslations.DataLoaded.GetLang());
  }

  protected override void CreateBindingLists()
  {
    OnLoadingData(SysTranslations.BindingData.GetLang());
    TweetsMainAsBindingList = new BindingListView<TweetRow>(Tweets.Where(t => t.Type == TweetType.Main).ToList());
    TweetsRepliesAsBindingList = new BindingListView<TweetRow>(Tweets.Where(t => t.Type == TweetType.Reply).ToList());
    TweetsRTsAsBindingList = new BindingListView<TweetRow>(Tweets.Where(t => t.Type == TweetType.RT).ToList());
    OnDataLoaded(SysTranslations.DataBinded.GetLang());
  }

  protected override void DoSaveAll()
  {
    if ( !HasChanges ) return;
    CheckAccess(Tweets, TweetsTableName);
    Connection.UpdateAll(ModifiedObjects);
    ModifiedObjects.Clear();
  }

  public void DeleteAll()
  {
    CheckConnected();
    CheckAccess(Tweets, TweetsTableName);
    Connection.DeleteAll<TweetRow>();
    Tweets.Clear();
  }

  protected override bool CreateDataIfNotExist(bool reset = false)
  {
    return false;
  }

}
