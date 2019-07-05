using Microsoft.Win32;

using System;
using System.Windows.Forms;

namespace TweakUtility
{
    internal static class Program
    {
        public static RegistryKey LocalMachine;
        public static RegistryKey CurrentUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            LocalMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, GetRegistryView());
            CurrentUser = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, GetRegistryView());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static RegistryView GetRegistryView()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                return RegistryView.Registry64;
            }

            return RegistryView.Registry32;
        }

        public static bool IsSupported(this OperatingSystemVersion mininum, OperatingSystemVersion? maximum = null)
        {
            Version mininumV = OperatingSystemVersions.GetVersion(mininum);
            Version maximumV = null;

            if (maximum.HasValue && maximum.Value != OperatingSystemVersion.None)
            {
                maximumV = OperatingSystemVersions.GetVersion(maximum.Value);
            }

            return IsSupported(mininumV, maximumV);
        }

        public static bool IsSupported(this Version mininum, Version maximum = null)
        {
            if (mininum is null)
            {
                throw new ArgumentNullException(nameof(mininum));
            }

            Version current = OperatingSystemVersions.GetCurrentVersion();

            if (current < mininum)
            {
                return false;
            }

            if (maximum != null && maximum < current)
            {
                return false;
            }

            return true;
        }
    }
}