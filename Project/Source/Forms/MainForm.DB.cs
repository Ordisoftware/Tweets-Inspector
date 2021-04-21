using System;
using System.Data.Odbc;
using Ordisoftware.Core;

namespace TwitterManager
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
