﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsApp1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=WIN-05LMG9MN0KA\\SQLEXPRESS;Initial Catalog=qlbhth2;Integrated Securit" +
            "y=True")]
        public string sqlCon {
            get {
                return ((string)(this["sqlCon"]));
            }
            set {
                this["sqlCon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-5D22BH6\\SQLEXPRESS;Initial Catalog=qlbhth2;Integrated Securit" +
            "y=True")]
        public string sqlCon2 {
            get {
                return ((string)(this["sqlCon2"]));
            }
            set {
                this["sqlCon2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int gioCheckIn {
            get {
                return ((int)(this["gioCheckIn"]));
            }
            set {
                this["gioCheckIn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("18")]
        public int gioCheckOut {
            get {
                return ((int)(this["gioCheckOut"]));
            }
            set {
                this["gioCheckOut"] = value;
            }
        }
    }
}
