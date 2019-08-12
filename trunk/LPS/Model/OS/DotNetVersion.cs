using LPS.Model.Extension;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.OS
{
    class DotNetVersion
    {
        public static float GetVersion()
        {
            float DotNetVersion = 0.0f;

            // Opens the registry key for the .NET Framework entry.
            using (RegistryKey ndpKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "")
                                                   .OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                // As an alternative, if you know the computers you will query are running .NET Framework 4.5 
                // or later, you can use:
                // using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, 
                // RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))                
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {
                        float QueryVersion = versionKeyName.Remove(0, 1).RemoveLastIndexof('.').ToFloat();
                        if (QueryVersion > DotNetVersion)
                            DotNetVersion = QueryVersion;
                    }
                }
            }

            return DotNetVersion;
        }

        public static void GetVersionFromRegistry()
        {
            // Opens the registry key for the .NET Framework entry.
            using (RegistryKey ndpKey =
                RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").
                OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                // As an alternative, if you know the computers you will query are running .NET Framework 4.5 
                // or later, you can use:
                // using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, 
                // RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {
                        RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                        string name = (string)versionKey.GetValue("Version", "");
                        string sp = versionKey.GetValue("SP", "").ToString();
                        string install = versionKey.GetValue("Install", "").ToString();
                        if (install == "") //no install info, must be later.
                            System.Diagnostics.Debug.WriteLine(versionKeyName + "  " + name);
                        else
                        {
                            if (sp != "" && install == "1")
                            {
                                System.Diagnostics.Debug.WriteLine(versionKeyName + "  " + name + "  SP" + sp);
                            }
                        }
                        if (name != "")
                        {
                            continue;
                        }

                        //4.0以後(不包含)的版本查詢;//
                        foreach (string subKeyName in versionKey.GetSubKeyNames())
                        {
                            RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                            name = (string)subKey.GetValue("Version", "");
                            if (name != "")
                                sp = subKey.GetValue("SP", "").ToString();
                            install = subKey.GetValue("Install", "").ToString();
                            if (install == "") //no install info, must be later.
                                System.Diagnostics.Debug.WriteLine(versionKeyName + "  " + name);
                            else
                            {
                                if (sp != "" && install == "1")
                                {
                                    System.Diagnostics.Debug.WriteLine("  " + subKeyName + "  " + name + "  SP" + sp);
                                }
                                else if (install == "1")
                                {
                                    System.Diagnostics.Debug.WriteLine("  " + subKeyName + "  " + name);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Get45PlusFromRegistry()
        {
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";

            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    System.Diagnostics.Debug.WriteLine(".NET Framework Version: " + CheckFor45PlusVersion((int)ndpKey.GetValue("Release")));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(".NET Framework Version 4.5 or later is not detected.");
                }
            }
        }

        // Checking the version using >= will enable forward compatibility.
        private static string CheckFor45PlusVersion(int releaseKey)
        {
            if (releaseKey >= 461308)
                return "4.7.1 or later";

            if (releaseKey >= 460798)
                return "4.7";

            if (releaseKey >= 394802)
                return "4.6.2";

            if (releaseKey >= 394254)
                return "4.6.1";

            if (releaseKey >= 393295)
                return "4.6";

            if ((releaseKey >= 379893))
                return "4.5.2";

            if ((releaseKey >= 378675))
                return "4.5.1";

            if ((releaseKey >= 378389))
                return "4.5";

            // This code should never execute. A non-null release key should mean
            // that 4.5 or later is installed.
            return "No 4.5 or later version detected";
        }
    }
}
