﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BriceLambson.ImageResizer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<CustomSize>\r\n  <Mode>Scale</Mode>\r\n  <Width>1280</Width>\r\n  <Height>720</Height>" +
            "\r\n  <Unit>Pixels</Unit>\r\n</CustomSize>")]
        public global::BriceLambson.ImageResizer.Models.CustomSize CustomSize {
            get {
                return ((global::BriceLambson.ImageResizer.Models.CustomSize)(this["CustomSize"]));
            }
            set {
                this["CustomSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ReplaceOriginals {
            get {
                return ((bool)(this["ReplaceOriginals"]));
            }
            set {
                this["ReplaceOriginals"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SelectedIndex {
            get {
                return ((int)(this["SelectedIndex"]));
            }
            set {
                this["SelectedIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShrinkOnly {
            get {
                return ((bool)(this["ShrinkOnly"]));
            }
            set {
                this["ShrinkOnly"] = value;
            }
        }
    }
}
