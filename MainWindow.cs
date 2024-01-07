using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleTrayRunner
{
    public partial class MainWindow : Form
    {
        string settingsIni = "SimpleTrayRunner.ini";

        public MainWindow()
        {
            InitializeComponent();
            StartInit();
        }

        void StartInit()
        {
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;

            Icon = Tray.Icon = Properties.Resources.favicon;
            Text += " v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            WorkPath.Text = System.AppDomain.CurrentDomain.BaseDirectory;
            if (System.IO.File.Exists(settingsIni)) { SettingsRead(); Job(); }
        }

        void SettingsWrite()
        {
            IniFile ini = new IniFile(settingsIni);

            string path = WorkPath.Text;
            string enableScripts = CheckBoxEnableScripts.Checked ? "1" : "0";
            string enableExclude = CheckBoxEnableExclude.Checked ? "1" : "0";
            string enableAutoStart = CheckBoxEnableAutoStart.Checked ? "1" : "0";
            ini.Write("Path", path);
            ini.Write("EnableScripts", enableScripts);
            ini.Write("EnableExclude", enableExclude);
            ini.Write("EnableAutoStart", enableAutoStart);
        }

        void SettingsRead()
        {
            IniFile ini = new IniFile(settingsIni);

            string path = ini.Read("Path");
            string enableScripts = ini.Read("EnableScripts");
            string enableExclude = ini.Read("EnableExclude");
            string enableAutoStart = ini.Read("EnableAutoStart");
            WorkPath.Text = path;
            CheckBoxEnableScripts.Checked = enableScripts == "1";
            CheckBoxEnableExclude.Checked = enableExclude == "1";
            CheckBoxEnableAutoStart.Checked = enableAutoStart == "1";
        }

        void AutoStart(bool createLnk)
        {
            string shortcutPath = Path.Combine(
                Environment.GetEnvironmentVariable("APPDATA"),
                @"Microsoft\Windows\Start Menu\Programs\Startup\SimpleTrayRunner.lnk");

            if (!createLnk) { System.IO.File.Delete(shortcutPath); return; }

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            //shortcut.Description = "New shortcut for a Notepad";
            //shortcut.Hotkey = "Ctrl+Shift+N";
            shortcut.WorkingDirectory = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            shortcut.TargetPath = shortcut.IconLocation = Environment.GetCommandLineArgs()[0];
            shortcut.Save();
        }

        void MainWindowShow(bool showWindow)
        {
            if (showWindow)
            {
                Show();
                Tray.Visible = false;
            }
            else
            {
                Hide();
                Tray.Visible = true;
            }
        }

        void Job()
        {
            void RunFile(string filePath)
            {
                switch (Path.GetExtension(filePath))
                {
                    case ".exe":
                    case ".cmd":
                    case ".bat":
                    case ".vbs":
                    case ".lnk":
                        Process.Start(filePath); break;

                    case ".ps1":
                        Process.Start(new ProcessStartInfo("powershell.exe", $"-EP bypass -f \"{filePath}\""));
                        break;

                    default: break;
                }
            }

            string path = WorkPath.Text;
            bool enableScripts = CheckBoxEnableScripts.Checked;
            bool enableExclude = CheckBoxEnableExclude.Checked;
            string regex = enableExclude ? @"^[^\#].*" : @"";
            regex += enableScripts ? @"\.(ps1|cmd|bat|vbs|exe)$" : @"\.exe$";

            if (!Directory.Exists(path)) { if (System.IO.File.Exists(path)) { RunFile(path); } }
            else
            {
                foreach (var file in Directory.EnumerateFiles(path, "*", SearchOption.TopDirectoryOnly))
                {
                    if (!Regex.IsMatch(Path.GetFileName(file), regex)) { continue; }
                    RunFile(file);
                }
            }
        }



        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e) => Job();

        private void MainWindow_Shown(object sender, EventArgs e) => MainWindowShow(false);

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MainWindowShow(false);
                SettingsWrite();
                e.Cancel = true;
            }
        }

        private void Tray_DoubleClick(object Sender, EventArgs e) => MainWindowShow(true);
        
        private void TrayMenuQuit_Click(object sender, EventArgs e) => Application.Exit();

        private void InfoTextMSDNLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://learn.microsoft.com/en-us/dotnet/api/microsoft.win32.systemevents.powermodechanged?view=netframework-4.5.2");
        }

        private void CheckBoxEnableScripts_CheckedChanged(object sender, EventArgs e) => SettingsWrite();

        private void CheckBoxEnableExclude_CheckedChanged(object sender, EventArgs e) => SettingsWrite();

        private void CheckBoxEnableAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            AutoStart(CheckBoxEnableAutoStart.Checked);
            SettingsWrite();
        }

        private void ScriptPathButtonOK_Click(object sender, EventArgs e) => SettingsWrite();

        private void InfoTextGitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/wvzxn");
        }

    }
}
