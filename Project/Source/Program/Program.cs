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

public enum TweetType { Main, Reply, RT };

/// <summary>
/// Provides Program class.
/// </summary>
static partial class Program
{

  /// <summary>
  /// Indicates the default Settings instance.
  /// </summary>
  static public readonly Properties.Settings Settings
    = Properties.Settings.Default;

  /// <summary>
  /// Process startup method.
  /// </summary>
  [STAThread]
  static void Main()
  {
    try
    {
      Globals.ChronoStartingApp.Start();
      Globals.SoftpediaURL = "";
      Globals.AlternativeToURL = "";
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Language lang = Settings.LanguageSelected;
      //SystemManager.CheckCommandLineArguments<ApplicationCommandLine>(args, ref lang);
      // No IPCAnswers
      // No IPCRequests
      //bool upgrade = Settings.UpgradeRequired;
      //Globals.IsSettingsUpgraded = upgrade;
      //Settings.CheckUpgradeRequired(ref upgrade);
      //Settings.UpgradeRequired = upgrade;
      //Globals.IsSettingsUpgraded = Globals.IsSettingsUpgraded && !Settings.FirstLaunch;
      //CheckSettingsReset();
      //if ( lang != Language.None ) Settings.LanguageSelected = lang;
      SystemManager.TryCatch(Settings.Save);
      Globals.Settings = Settings;
      Globals.MainForm = MainForm.Instance;
      DebugManager.TraceEnabled = true;// Settings.TraceEnabled;
      DebugManager.Enabled = true;// Settings.DebuggerEnabled;
      Globals.ChronoStartingApp.Stop();
      //ProcessCommandLineOptions();
      Globals.ChronoStartingApp.Start();
      //LoadingForm.Instance.Hidden = Settings.LoadingFormHidden;
      AboutBox.LicenseAsRTF = Properties.Resources.MPL_2_0;
      //AboutBox.DescriptionText = AppTranslations.ApplicationDescription;
      //AboutBox.Instance.ActionViewStats.Enabled = Settings.UsageStatisticsEnabled;
      DebugManager.Enabled = true;
      DebugManager.TraceEnabled = true;
      // TODO check old config TweetsInsoector -> Tweets.Inspector
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    Application.Run(MainForm.Instance);
    SystemManager.Exit();
  }

}
