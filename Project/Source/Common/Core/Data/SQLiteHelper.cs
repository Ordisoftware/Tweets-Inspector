/// <license>
/// This file is part of Ordisoftware Core Library.
/// Copyright 2004-2021 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2019-01 </created>
/// <edited> 2021-05 </edited>
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SQLite;

namespace Ordisoftware.Core
{

  /// <summary>
  /// Provide System.Data.SQLite helper.
  /// </summary>
  static partial class SQLiteHelper
  {

    static public int DefaultOptimizeDaysInterval { get; set; } = Globals.DaysOfWeekCount;

    /// <summary>
    /// Indicate the database engine name and version.
    /// </summary>
    static public string EngineNameAndVersion { get; private set; }

    /// <summary>
    /// Indicate the ADO.NET provider name.
    /// </summary>
    static public string ADOdotNETProviderName { get; private set; }

    /// <summary>
    /// Get a single line of a string.
    /// </summary>
    /// <param name="sql"></param>
    static public string UnformatSQL(string sql)
    {
      return sql.SplitNoEmptyLines().Select(line => line.Trim()).AsMultiSpace();
    }

    /// <summary>
    /// Return true if only one instance of the process is running else false.
    /// </summary>
    /// <param name="silent">True if no message is shown else shown.</param>
    /// <returns></returns>
    static public bool CheckProcessConcurency(bool silent = false)
    {
      var list = System.Diagnostics.Process.GetProcessesByName(Globals.ProcessName);
      bool valid = list.Length == 1;
      if ( !valid && !silent )
        DisplayManager.ShowWarning(SysTranslations.DatabaseNoProcessConcurrency.GetLang());
      return valid;
    }

    /// <summary>
    /// Get the version of the engine.
    /// </summary>
    /// <param name="connection">The connection.</param>
    static public void InitializeVersion(this SQLiteConnection connection)
    {
      ADOdotNETProviderName = connection?.GetType().Name ?? SysTranslations.ErrorSlot.GetLang();
      EngineNameAndVersion = ( "SQLite " + connection?.ServerVersion ) ?? SysTranslations.ErrorSlot.GetLang();
    }

    /// <summary>
    /// Optimize the database.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="lastdone">The last done date.</param>
    /// <param name="interval">Days interval to check.</param>
    /// <param name="force">True to force check.</param>
    /// <returns>The new date if done else lastdone.</returns>
    static public DateTime Optimize(this SQLiteConnection connection, DateTime lastdone, int interval = -1, bool force = false)
    {
      if ( interval == -1 ) interval = DefaultOptimizeDaysInterval;
      InitializeVersion(connection);
      if ( force || lastdone.AddDays(interval) < DateTime.Now )
      {
        connection.CheckIntegrity();
        connection.Vacuum();
        lastdone = DateTime.Now;
      }
      return lastdone;
    }

    /// <summary>
    /// Vacuum the database.
    /// </summary>
    /// <param name="connection">The connection.</param>
    static public void CheckIntegrity(this SQLiteConnection connection)
    {
      SystemManager.TryCatchManage(() =>
      {
        var errors = new List<string>();
        using ( var command = new SQLiteCommand("SELECT integrity_check FROM pragma_integrity_check()", connection) )
        using ( var reader = command.ExecuteReader() )
          while ( reader.Read() )
          {
            string data = reader.GetString(0);
            if ( data != "ok" ) errors.Add(data);
          }
        if ( errors.Count > 0 )
        {
          string msg = SysTranslations.DatabaseIntegrityError.GetLang(errors.AsMultiLine());
          throw new SQLiteException(msg);
        }
      });
    }

    /// <summary>
    ///  Vacuum the database.
    /// </summary>
    /// <param name="connection">The connection.</param>
    static public void Vacuum(this SQLiteConnection connection)
    {
      SystemManager.TryCatchManage(() =>
      {
        using ( var command = new SQLiteCommand("VACUUM", connection) )
          if ( command.ExecuteNonQuery() != 0 )
            throw new SQLiteException(SysTranslations.DatabaseVacuumError.GetLang());
      });
    }

    /// <summary>
    /// Drop a table if exists.
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="table"></param>
    static public void DropTableIfExists(this SQLiteConnection connection, string table)
    {
      string argnameTable = nameof(table);
      SystemManager.TryCatchManage(() =>
      {
        if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(argnameTable);
        using ( var command = new SQLiteCommand($"DROP TABLE IF EXISTS {table}", connection) )
          try
          {
            command.ExecuteNonQuery();
          }
          catch ( Exception ex )
          {
            throw new SQLiteException(SysTranslations.DBDropTableError.GetLang(table), ex);
          }
      });
    }

    /// <summary>
    /// Check if a table exists and create it if not.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="table">The table name.</param>
    /// <param name="sql">The sql query to create the table, can be empty to only check.</param>
    /// <returns>True if the table exists else false even if created.</returns>
    static public bool CheckTable(this SQLiteConnection connection, string table, string sql = "")
    {
      try
      {
        if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(table));
        using ( var commandCheck = connection.CreateCommand() )
        {
          commandCheck.CommandText = $"SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name = ?";
          commandCheck.Parameters.Add("@table", DbType.String).Value = table;
          if ( (long)commandCheck.ExecuteScalar() != 0 ) return true;
          if ( !sql.IsNullOrEmpty() )
            using ( var commandCreate = new SQLiteCommand(sql, connection) )
              try
              {
                commandCreate.ExecuteNonQuery();
              }
              catch ( Exception ex )
              {
                throw new SQLiteException(SysTranslations.DBCreateTableError.GetLang(UnformatSQL(sql)), ex);
              }
        }
      }
      catch ( Exception ex )
      {
        throw new SQLiteException($"Error in {nameof(CheckTable)}", ex);
      }
      return false;
    }

    /// <summary>
    /// Check if a index exists and create it if not.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="index">The index name.</param>
    /// <param name="sql">The sql query to create the table, can be empty to only check.</param>
    /// <returns>True if the index exists else false even if created.</returns>
    static public bool CheckIndex(this SQLiteConnection connection, string index, string sql = "")
    {
      try
      {
        if ( index.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(index));
        using ( var commandCheck = connection.CreateCommand() )
        {
          commandCheck.CommandText = $"SELECT count(*) FROM sqlite_master WHERE type = 'index' AND name = ?";
          commandCheck.Parameters.Add("@index", DbType.String).Value = index;
          if ( (long)commandCheck.ExecuteScalar() != 0 ) return true;
          if ( !sql.IsNullOrEmpty() )
            using ( var commandCreate = new SQLiteCommand(sql, connection) )
              try
              {
                commandCreate.ExecuteNonQuery();
              }
              catch ( Exception ex )
              {
                throw new SQLiteException(SysTranslations.DBCreateTableError.GetLang(UnformatSQL(sql)), ex);
              }
        }
      }
      catch ( Exception ex )
      {
        throw new SQLiteException($"Error in {nameof(CheckIndex)}", ex);
      }
      return false;
    }

    /// <summary>
    /// Check if a column of a table exists and create it if not.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="table">The table name.</param>
    /// <param name="column">The column name.</param>
    /// <param name="sql">The sql query to create the column, can be empty to only check</param>
    /// <returns>True if the column exists else false even if created.</returns>
    static public bool CheckColumn(this SQLiteConnection connection, string table, string column, string sql = "")
    {
      try
      {
        if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(table));
        if ( column.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(column));
        using ( var commandCheck = new SQLiteCommand($"PRAGMA table_info({table})", connection) )
        using ( var readerCheck = commandCheck.ExecuteReader() )
        {
          int nameIndex = readerCheck.GetOrdinal("Name");
          while ( readerCheck.Read() )
            if ( readerCheck.GetString(nameIndex).Equals(column) )
              return true;
          if ( !sql.IsNullOrEmpty() )
          {
            sql = sql.Replace("%TABLE%", table).Replace("%COLUMN%", column);
            using ( var commandCreate = new SQLiteCommand(sql, connection) )
              try
              {
                commandCreate.ExecuteNonQuery();
              }
              catch ( Exception ex )
              {
                throw new SQLiteException(SysTranslations.DBCreateColumnError.GetLang(UnformatSQL(sql)), ex);
              }
          }
        }
      }
      catch ( Exception ex )
      {
        throw new SQLiteException($"Error in {nameof(CheckColumn)}", ex);
      }
      return false;
    }

    /// <summary>
    /// Check if a column of a table exists and create it if not.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="table">The table name.</param>
    /// <param name="column">The column name.</param>
    /// <param name="type">The type of the column.</param>
    /// <param name="valueDefault">The default value.</param>
    /// <param name="valueNotNull">Indicate if not null.</param>
    /// <returns>True if the column exists else false even if created.</returns>
    static public bool CheckColumn(this SQLiteConnection connection,
                                   string table,
                                   string column,
                                   string type,
                                   string valueDefault,
                                   bool valueNotNull)
    {
      if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(table));
      if ( column.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(column));
      if ( type.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(type));
      if ( !valueDefault.IsNullOrEmpty() ) valueDefault = " DEFAULT " + valueDefault;
      if ( valueNotNull ) valueDefault += " NOT NULL";
      string sql = $"ALTER TABLE %TABLE% ADD COLUMN %COLUMN% {type} {valueDefault}";
      return connection.CheckColumn(table, column, sql);
    }

    /// <summary>
    /// Get the number of rows in a table.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="table">The table name.</param>
    /// <returns></returns>
    static public int GetRowsCount(this SQLiteConnection connection, string table)
    {
      int count = -1;
      try
      {
        using ( var command = new SQLiteCommand($"SELECT COUNT(ID) FROM [{table}]", connection) )
        {
          var reader = command.ExecuteReader();
          if ( reader.Read() ) count = (int)reader[0];
        }
      }
      catch ( Exception ex )
      {
        throw new SQLiteException($"Error in {nameof(GetRowsCount)}", ex);
      }
      return count;
    }

  }

}
