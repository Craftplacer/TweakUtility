﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TweakUtility.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TweakUtility.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tweak Utility.
        /// </summary>
        internal static string Application_Name {
            get {
                return ResourceManager.GetString("Application_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backups.
        /// </summary>
        internal static string Backups {
            get {
                return ResourceManager.GetString("Backups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This folder contains backups made by Tweak Utility. .
        /// </summary>
        internal static string Backups_FolderDescription {
            get {
                return ResourceManager.GetString("Backups_FolderDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open Backups &amp;Folder.
        /// </summary>
        internal static string Backups_OpenFolder {
            get {
                return ResourceManager.GetString("Backups_OpenFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extensions.
        /// </summary>
        internal static string Extensions {
            get {
                return ResourceManager.GetString("Extensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This folder contains extensions for Tweak Utility..
        /// </summary>
        internal static string Extensions_FolderDescription {
            get {
                return ResourceManager.GetString("Extensions_FolderDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open Extensions &amp;Folder.
        /// </summary>
        internal static string Extensions_OpenFolder {
            get {
                return ResourceManager.GetString("Extensions_OpenFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to backup the files before proceeding?.
        /// </summary>
        internal static string MsnMessenger_AudioBackup {
            get {
                return ResourceManager.GetString("MsnMessenger_AudioBackup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to restore the files?.
        /// </summary>
        internal static string MsnMessenger_AudioRestore {
            get {
                return ResourceManager.GetString("MsnMessenger_AudioRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to remove the OneDrive folder?.
        /// </summary>
        internal static string OneDrive_Uninstall_DeleteFolder {
            get {
                return ResourceManager.GetString("OneDrive_Uninstall_DeleteFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete the OneDrive folder because of following error message:
        ///
        ///{0}.
        /// </summary>
        internal static string OneDrive_Uninstall_DeleteFolder_Failed {
            get {
                return ResourceManager.GetString("OneDrive_Uninstall_DeleteFolder_Failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The uninstall info for OneDrive couldn&apos;t be found.
        ///Therefore, OneDrive won&apos;t be automatically uninstalled, you can continue deleting directories and registry entries related to it. 
        ///
        ///Do you want to continue?.
        /// </summary>
        internal static string OneDrive_Uninstall_InstallerNotFound {
            get {
                return ResourceManager.GetString("OneDrive_Uninstall_InstallerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Currently, the &quot;user initiated uninstallation&quot; flag isn&apos;t set, possibly leading Windows into reinstalling OneDrive.
        ///Setting this flag will tell Windows that you want to keep OneDrive uninstalled.
        ///
        ///Would you like to switch on?.
        /// </summary>
        internal static string OneDrive_Uninstall_SetFlagMessage {
            get {
                return ResourceManager.GetString("OneDrive_Uninstall_SetFlagMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OneDrive, along with its trails, have been deleted..
        /// </summary>
        internal static string OneDrive_Uninstall_Success {
            get {
                return ResourceManager.GetString("OneDrive_Uninstall_Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OneDrive uninstaller didn&apos;t seem to run correctly.
        ///
        ///Do you want to continue?.
        /// </summary>
        internal static string OneDrive_Uninstall_Warning {
            get {
                return ResourceManager.GetString("OneDrive_Uninstall_Warning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option requires you to restart Windows Explorer.
        ///
        ///Would you like to do that now?.
        /// </summary>
        internal static string Reload_ExplorerRestart {
            get {
                return ResourceManager.GetString("Reload_ExplorerRestart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option requires you to log off.
        ///
        ///Would you like to do that now?.
        /// </summary>
        internal static string Reload_LogOff {
            get {
                return ResourceManager.GetString("Reload_LogOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option requires you to restart your system.
        ///
        ///Would you like to do that now?.
        /// </summary>
        internal static string Reload_SystemRestart {
            get {
                return ResourceManager.GetString("Reload_SystemRestart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option requires you to reload the thing related to it, as there isn&apos;t a refresh implemented yet.
        ///
        ///If you know how to implement this refresh programmatically, please let us know by clicking the feedback button in the about window..
        /// </summary>
        internal static string Reload_Unknown {
            get {
                return ResourceManager.GetString("Reload_Unknown", resourceCulture);
            }
        }
    }
}