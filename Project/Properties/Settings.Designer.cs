//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ordisoftware.Tweets.Inspector.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DeleteOnlyLocalMode {
            get {
                return ((bool)(this["DeleteOnlyLocalMode"]));
            }
            set {
                this["DeleteOnlyLocalMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ConsumerKey {
            get {
                return ((string)(this["ConsumerKey"]));
            }
            set {
                this["ConsumerKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ConsumerSecret {
            get {
                return ((string)(this["ConsumerSecret"]));
            }
            set {
                this["ConsumerSecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ConsumerBackUrl {
            get {
                return ((string)(this["ConsumerBackUrl"]));
            }
            set {
                this["ConsumerBackUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SearchInRecipients {
            get {
                return ((bool)(this["SearchInRecipients"]));
            }
            set {
                this["SearchInRecipients"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SearchInMessage {
            get {
                return ((bool)(this["SearchInMessage"]));
            }
            set {
                this["SearchInMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::Ordisoftware.Tweets.Inspector.StartupConnectAction StartupConnectAction {
            get {
                return ((global::Ordisoftware.Tweets.Inspector.StartupConnectAction)(this["StartupConnectAction"]));
            }
            set {
                this["StartupConnectAction"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SingleClickUserFilter {
            get {
                return ((bool)(this["SingleClickUserFilter"]));
            }
            set {
                this["SingleClickUserFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool VacuumAtStartup {
            get {
                return ((bool)(this["VacuumAtStartup"]));
            }
            set {
                this["VacuumAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000-01-01")]
        public global::System.DateTime VacuumLastDone {
            get {
                return ((global::System.DateTime)(this["VacuumLastDone"]));
            }
            set {
                this["VacuumLastDone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int VacuumAtStartupDaysInterval {
            get {
                return ((int)(this["VacuumAtStartupDaysInterval"]));
            }
            set {
                this["VacuumAtStartupDaysInterval"] = value;
            }
        }
    }
}
