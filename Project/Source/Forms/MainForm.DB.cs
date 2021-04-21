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
