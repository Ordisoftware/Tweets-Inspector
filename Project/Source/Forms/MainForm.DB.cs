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
using System.Data.Odbc;
using Ordisoftware.Core;

namespace Ordisoftware.TwitterManager
{

  public partial class MainForm
  {

    static internal OdbcConnection LockFileConnection;

    private void CreateSchemaIfNotExists()
    {
      SystemManager.TryCatchManage(() =>
      {
        SQLiteOdbcHelper.CreateOrUpdateDSN();
        LockFileConnection = new OdbcConnection(Settings.ConnectionString);
        LockFileConnection.Open();
        LockFileConnection.CheckIntegrity();
        LockFileConnection.Vacuum();
        LockFileConnection.CheckTable(@"Tweets",
                                      @"CREATE TABLE Tweets
                                        ( 
                                          Id INTEGER NOT NULL,
                                          Date TEXT DEFAULT '' NOT NULL,
                                          Type INTEGER DEFAULT 0 NOT NULL,
                                          Recipients TEXT DEFAULT '' NOT NULL,
                                          Message TEXT DEFAULT '' NOT NULL,
                                          PRIMARY KEY(Id)
                                        )");
        LockFileConnection.CheckTable(@"Following",
                                      @"CREATE TABLE Following
                                        ( 
                                          Id INTEGER NOT NULL,
                                          ScreenName TEXT DEFAULT '' NOT NULL,
                                          DateInserted TEXT DEFAULT '' NOT NULL,
                                          DateRemoved TEXT DEFAULT '' NOT NULL,
                                          PRIMARY KEY(Id)
                                        )");
        LockFileConnection.CheckTable(@"Followers",
                                      @"CREATE TABLE Followers
                                        ( 
                                          Id INTEGER NOT NULL,
                                          ScreenName TEXT DEFAULT '' NOT NULL,
                                          DateInserted TEXT DEFAULT '' NOT NULL,
                                          DateRemoved TEXT DEFAULT '' NOT NULL,
                                          PRIMARY KEY(Id)
                                        )");
        LockFileConnection.CheckIndex(@"idx_following_screenname",
                                      @"CREATE UNIQUE INDEX idx_following_screenname ON Following(ScreenName)");
        LockFileConnection.CheckIndex(@"idx_followers_screenname",
                                      @"CREATE UNIQUE INDEX idx_followers_screenname ON Followers(ScreenName)");
      });
    }

    private void LoadData()
    {
      var command = new OdbcCommand("SELECT * FROM Tweets", LockFileConnection);
      var reader = command.ExecuteReader();
      while ( reader.Read() )
      {
        var tweet = new Tweet();
        tweet.Id = reader.GetInt64(0);
        tweet.Date = reader.GetString(1);
        tweet.Type = (TweetType)reader.GetInt32(2);
        tweet.Recipients = reader.GetString(3);
        tweet.Message = reader.GetString(4);
        Tweets.Add(tweet);
      }
    }

  }

}
