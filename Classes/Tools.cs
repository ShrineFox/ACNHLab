using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACNHLab
{
    class Tools
    {
        #region Win32Functions
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetFocus(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        static extern IntPtr GetMenu(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int GetMenuItemCount(IntPtr hMenu);
        [DllImport("user32.dll")]
        static extern bool DrawMenuBar(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DestroyWindow(IntPtr hwnd);

        const int GWL_STYLE = (-16);
        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 2;
        private const int SW_NORMALE = 1;
        public static uint MF_BYPOSITION = 0x400;
        public static uint MF_REMOVE = 0x1000;
        const uint WS_VISIBLE = 0x10000000;
        #endregion

        public static FileStream WaitForFile(string fullPath, FileMode mode, FileAccess access, FileShare share)
        {
            for (int numTries = 0; numTries < 10; numTries++)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(fullPath, mode, access, share);
                    return fs;
                }
                catch (IOException)
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                    Thread.Sleep(1000);
                }
            }
            return null;
        }

        /* Get Path to Python executable of a certain version range */
        public static string GetPythonPath(string requiredVersion = "", string maxVersion = "", string requiredScript = "")
        {
            string[] possiblePythonLocations = new string[3] {
                @"HKLM\SOFTWARE\Python\PythonCore\",
                @"HKCU\SOFTWARE\Python\PythonCore\",
                @"HKLM\SOFTWARE\Wow6432Node\Python\PythonCore\"
            };

            //Version number, install path
            Dictionary<string, string> pythonLocations = new Dictionary<string, string>();

            foreach (string possibleLocation in possiblePythonLocations)
            {
                try
                {
                    string regKey = possibleLocation.Substring(0, 4), actualPath = possibleLocation.Substring(5);
                    RegistryKey theKey = (regKey == "HKLM" ? Registry.LocalMachine : Registry.CurrentUser);
                    RegistryKey theValue = theKey.OpenSubKey(actualPath);

                    foreach (var v in theValue.GetSubKeyNames())
                    {
                        RegistryKey productKey = theValue.OpenSubKey(v);
                        if (productKey != null)
                        {
                            try
                            {
                                string pythonExePath = productKey.OpenSubKey("InstallPath").GetValue("ExecutablePath").ToString();
                                if (pythonExePath != null && pythonExePath != "")
                                    if (requiredScript != "" && File.Exists(Path.Combine(Path.GetDirectoryName(pythonExePath), Path.Combine("Scripts", requiredScript))))
                                        pythonLocations.Add(v.ToString(), pythonExePath);
                            } catch { }
                        }
                    }
                }
                catch { }
            }

            if (pythonLocations.Count > 0)
            {
                System.Version desiredVersion = new System.Version(requiredVersion == "" ? "0.0.1" : requiredVersion),
                    maxPVersion = new System.Version(maxVersion == "" ? "999.999.999" : maxVersion);

                string highestVersion = "", highestVersionPath = "";

                foreach (KeyValuePair<string, string> pVersion in pythonLocations)
                {
                    //Require 64 bit
                    if (!pVersion.Value.Contains("-32"))
                    {
                        int index = pVersion.Key.IndexOf("-"); //For x-32 and x-64 in version numbers
                        string formattedVersion = index > 0 ? pVersion.Key.Substring(0, index) : pVersion.Key;

                        System.Version thisVersion = new System.Version(formattedVersion);
                        int comparison = desiredVersion.CompareTo(thisVersion),
                            maxComparison = maxPVersion.CompareTo(thisVersion);

                        if (comparison <= 0)
                        {
                            //Version is greater or equal
                            if (maxComparison >= 0)
                            {
                                desiredVersion = thisVersion;

                                highestVersion = pVersion.Key;
                                highestVersionPath = pVersion.Value;
                            }
                            else
                            {
                                //Console.WriteLine("Version is too high; " + maxComparison.ToString());
                            }
                        }
                        else
                        {
                            //Console.WriteLine("Version (" + pVersion.Key + ") is not within the spectrum.");
                        }
                    }
                }

                //Console.WriteLine(highestVersion);
                //Console.WriteLine(highestVersionPath);
                return highestVersionPath;
            }

            return "";
        }

        public static void KillCMD(string procName)
        {
            foreach (Process proc in Process.GetProcessesByName(procName))
                proc.Kill();
        }

        public static void CMD(string program, string args = "")
        {
            Process p = new Process();
            p.StartInfo.FileName = program;
            p.StartInfo.Arguments = args;
            p.Start();
        }
    }
}