﻿/// <license>
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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Core;

using SQLite;

/// <summary>
/// Provides specialized SQLiteConnection.
/// </summary>
public class SQLiteNetORM : SQLiteConnection
{
  public SQLiteNetORM(SQLiteConnectionString connectionString) : base(connectionString) { }
  public SQLiteNetORM(string databasePath, bool storeDateTimeAsTicks = true) : base(databasePath, storeDateTimeAsTicks) { }
  public SQLiteNetORM(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = true) : base(databasePath, openFlags, storeDateTimeAsTicks) { }
}

/// <summary>
/// Provides SQLite-Net helper.
/// </summary>
static class SQLiteNetHelper
{

  static public int DefaultOptimizeDaysInterval { get; set; } = 7;

  /// <summary>
  /// Indicates the database engine name and version.
  /// </summary>
  static public string EngineNameAndVersion { get; private set; }

  /// <summary>
  /// Indicates the provider name.
  /// </summary>
  static public string ProviderName { get; private set; }

  /// <summary>
  /// Gets a single line of a string.
  /// </summary>
  /// <param name="sql"></param>
  static public string UnformatSQL(string sql)
  {
    return sql.SplitNoEmptyLines().Select(line => line.Trim()).AsMultiSpace();
  }

  /// <summary>
  /// Returns true if only one instance of the process is running else false.
  /// </summary>
  /// <param name="silent">True if no message is shown else shown.</param>
  static public bool CheckProcessConcurency(bool silent = false)
  {
    var list = System.Diagnostics.Process.GetProcessesByName(Globals.ProcessName);
    bool valid = list.Length == 1;
    if ( !valid && !silent )
      DisplayManager.ShowWarning(SysTranslations.DatabaseNoProcessConcurrency.GetLang());
    return valid;
  }

  /// <summary>
  /// Gets the version of the engine.
  /// </summary>
  /// <param name="connection">The connection.</param>
  static public void InitializeVersion(this SQLiteNetORM connection)
  {
    ProviderName = connection?.GetType().Name ?? SysTranslations.ErrorSlot.GetLang();
    int vernum = connection?.LibVersionNumber ?? -1;
    if ( vernum == -1 )
      EngineNameAndVersion = SysTranslations.UnknownSlot.GetLang();
    else
    {
      string version = vernum.ToString();
      string build = int.Parse(new string(version.TakeLast(3).ToArray())).ToString();
      string minor = int.Parse(new string(version.SkipLast(3).TakeLast(3).ToArray())).ToString();
      string major = int.Parse(new string(version.SkipLast(6).ToArray())).ToString();
      EngineNameAndVersion = $"SQLite {major}.{minor}.{build}";
    }
  }

  /// <summary>
  /// Creates a SQL command.
  /// </summary>
  /// <param name="connection">The connection.</param>
  static public SQLiteCommand CreateCommand(this SQLiteNetORM connection)
  {
    return new SQLiteCommand(connection);
  }

  /// <summary>
  /// Creates a SQL command.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="sql">The query.</param>
  static public SQLiteCommand CreateCommand(this SQLiteNetORM connection, string sql)
  {
    return new SQLiteCommand(connection) { CommandText = sql };
  }

  /// <summary>
  /// Optimizes the database.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="lastdone">The last done date.</param>
  /// <param name="interval">Days interval to check.</param>
  /// <param name="force">True to force check.</param>
  /// <returns>The new date if done else lastdone.</returns>
  static public DateTime Optimize(this SQLiteNetORM connection, DateTime lastdone, int interval = -1, bool force = false)
  {
    if ( interval == -1 ) interval = DefaultOptimizeDaysInterval;
    if ( force || lastdone.AddDays(interval) < DateTime.Now )
    {
      connection.CheckIntegrity();
      connection.Vacuum();
      lastdone = DateTime.Now;
    }
    return lastdone;
  }

  /// <summary>
  /// Checks the database integrity.
  /// </summary>
  /// <param name="connection">The connection.</param>
  static public void CheckIntegrity(this SQLiteNetORM connection)
  {
    SystemManager.TryCatchManage(() =>
    {
      string result = connection.ExecuteScalar<string>("SELECT integrity_check FROM pragma_integrity_check()");
      if ( result != "ok" )
      {
        throw new SQLiteException(result);
      }
    });
  }

  /// <summary>
  /// Does the database Vacuum.
  /// </summary>
  /// <param name="connection">The connection.</param>
  static public void Vacuum(this SQLiteNetORM connection)
  {
    try
    {
      connection.Execute("VACUUM");
    }
    catch ( Exception ex )
    {
      throw new SQLiteException(SysTranslations.DatabaseVacuumError.GetLang(), ex);
    }
  }

  /// <summary>
  /// Drops a table if exists.
  /// </summary>
  /// <param name="connection"></param>
  /// <param name="table"></param>
  static public void DropTableIfExists(this SQLiteNetORM connection, string table)
  {
    const string argnameTable = nameof(table);
    if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(argnameTable);
    try
    {
      connection.Execute($"DROP TABLE IF EXISTS [{table}]");
    }
    catch ( Exception ex )
    {
      throw new SQLiteException(SysTranslations.DBDropTableError.GetLang(table), ex);
    }
  }

  /// <summary>
  /// Renames a table if exists.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="tableOldName">Old name.</param>
  /// <param name="tableNewName">New name.</param>
  static public void RenameTableIfExists(this SQLiteNetORM connection, string tableOldName, string tableNewName)
  {
    const string argnameTableOld = nameof(tableOldName);
    const string argnameTableNew = nameof(tableNewName);
    if ( tableOldName.IsNullOrEmpty() ) throw new ArgumentNullException(argnameTableOld);
    if ( tableNewName.IsNullOrEmpty() ) throw new ArgumentNullException(argnameTableNew);
    try
    {
      connection.Execute($"ALTER TABLE [{tableOldName}] RENAME TO [{tableNewName}];");
    }
    catch ( Exception ex )
    {
      throw new SQLiteException(SysTranslations.DBRenameTableError.GetLang(argnameTableOld, argnameTableNew), ex);
    }
  }

  /// <summary>
  /// Checks if a table exists and create it if not.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="table">The table name.</param>
  /// <param name="sql">The sql query to create the table, can be empty to only check.</param>
  /// <returns>True if the table exists else false even if created.</returns>
  static public bool CheckTable(this SQLiteNetORM connection, string table, string sql = "")
  {
    try
    {
      if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(table));
      const string sqlSelect = "SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name = ?";
      if ( connection.ExecuteScalar<long>(sqlSelect, table) != 0 ) return true;
      if ( !sql.IsNullOrEmpty() )
        try
        {
          connection.CreateCommand(sql).ExecuteNonQuery();
        }
        catch ( Exception ex )
        {
          throw new SQLiteException(SysTranslations.DBCreateTableError.GetLang(table, UnformatSQL(sql)), ex);
        }
    }
    catch ( Exception ex )
    {
      throw new SQLiteException($"Error in {nameof(CheckTable)}", ex);
    }
    return false;
  }

  /// <summary>
  /// Checks if a index exists and create it if not.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="index">The index name.</param>
  /// <param name="sql">The sql query to create the table, can be empty to only check.</param>
  /// <returns>True if the index exists else false even if created.</returns>
  static public bool CheckIndex(this SQLiteNetORM connection, string index, string sql = "")
  {
    try
    {
      if ( index.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(index));
      const string sqlCheck = "SELECT count(*) FROM sqlite_master WHERE type = 'index' AND name = ?";
      if ( connection.ExecuteScalar<long>(sqlCheck, index) != 0 ) return true;
      if ( !sql.IsNullOrEmpty() )
        try
        {
          connection.Execute(sql);
        }
        catch ( Exception ex )
        {
          throw new SQLiteException(SysTranslations.DBCreateIndexError.GetLang(index, UnformatSQL(sql)), ex);
        }
    }
    catch ( Exception ex )
    {
      throw new SQLiteException($"Error in {nameof(CheckIndex)}", ex);
    }
    return false;
  }

  /// <summary>
  /// Checks if a column of a table exists and create it if not.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="table">The table name.</param>
  /// <param name="column">The column name.</param>
  /// <param name="sql">The sql query to create the column, can be empty to only check</param>
  /// <returns>True if the column exists else false even if created.</returns>
  static public bool CheckColumn(this SQLiteNetORM connection, string table, string column, string sql = "")
  {
    try
    {
      if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(table));
      if ( column.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(column));
      if ( !connection.CheckTable(table) ) return false;
      const string sqlCheck = "SELECT COUNT(*) AS CNTREC FROM pragma_table_info(?) WHERE name = ?";
      if ( connection.ExecuteScalar<long>(sqlCheck, table, column) > 0 ) return true;
      if ( !sql.IsNullOrEmpty() )
        try
        {
          sql = sql.Replace("%TABLE%", table).Replace("%COLUMN%", column);
          connection.Execute(sql);
        }
        catch ( Exception ex )
        {
          throw new SQLiteException(SysTranslations.DBCreateColumnError.GetLang(UnformatSQL(sql)), ex);
        }
    }
    catch ( Exception ex )
    {
      throw new SQLiteException($"Error in {nameof(CheckColumn)}", ex);
    }
    return false;
  }

  /// <summary>
  /// Checks if a column of a table exists and create it if not.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="table">The table name.</param>
  /// <param name="column">The column name.</param>
  /// <param name="type">The type of the column.</param>
  /// <param name="valueDefault">The default value.</param>
  /// <param name="valueNotNull">Indicate if not null.</param>
  /// <param name="isPrimary">Indicate if primary key.</param>
  /// <param name="isAutoInc">INdicate if auto inc.</param>
  /// <returns>True if the column exists else false even if created.</returns>
  static public bool CheckColumn(this SQLiteNetORM connection,
                                 string table,
                                 string column,
                                 string type,
                                 string valueDefault,
                                 bool valueNotNull,
                                 bool isPrimary,
                                 bool isAutoInc)
  {
    if ( table.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(table));
    if ( column.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(column));
    if ( type.IsNullOrEmpty() ) throw new ArgumentNullException(nameof(type));
    if ( !valueDefault.IsNullOrEmpty() ) valueDefault = " DEFAULT " + valueDefault;
    if ( valueNotNull ) valueDefault += " NOT NULL";
    string primary = isPrimary ? "PRIMARY KEY" : "";
    if ( isAutoInc ) primary += " AUTOINCREMENT ";
    string sql = $"ALTER TABLE %TABLE% ADD COLUMN %COLUMN% {type} {primary} {valueDefault}";
    return connection.CheckColumn(table, column, sql);
  }

  /// <summary>
  /// Gets the number of rows in a table.
  /// </summary>
  /// <param name="connection">The connection.</param>
  /// <param name="table">The table name.</param>
  static public long GetRowsCount(this SQLiteNetORM connection, string table)
  {
    try
    {
      return connection.ExecuteScalar<long>($"SELECT count(*) FROM [{table}]");
    }
    catch ( Exception ex )
    {
      throw new SQLiteException($"Error in {nameof(GetRowsCount)}", ex);
    }
  }

}
