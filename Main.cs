using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SimpleTrayRunner
{
    static class Settings
    {
        public static string Name = "SimpleTrayRunner";
        public static string Ini = Name + ".ini";
        public static string Log = Name + ".log";
        public static bool Enabled = false;
        public static bool EnableWinStart = false;
        public static bool EnableLogs = false;
        public static bool RunAtStart = false;
        public static string RunAtStartPath = @"C:\Example\runAtStart.exe";
        public static bool RunAtPower = false;
        public static string RunAtPowerPath = @"C:\Example\runAtPowerChange.exe";
    }

    static class Main
    {
        public static void Log(string text)
        {
            if (!Settings.EnableLogs) { return; }
            using (StreamWriter logFile = new StreamWriter(Settings.Log, true))
            {
                logFile.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + text);
            }
        }
        public static string GetOpenFileDialogPath()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
            };
            dialog.ShowDialog();
            return dialog.FileName;
        }
        public static void WriteIni(string IniPath)
        {
            IniFile ini = new IniFile(IniPath);
            ini.Write("Enabled", Settings.Enabled ? "1" : "0");
            ini.Write("EnableWinStart", Settings.EnableWinStart ? "1" : "0");
            ini.Write("EnableLogs", Settings.EnableLogs ? "1" : "0");
            ini.Write("RunAtStart", Settings.RunAtStart ? "1" : "0");
            ini.Write("RunAtStartPath", Settings.RunAtStartPath);
            ini.Write("RunAtPower", Settings.RunAtPower ? "1" : "0");
            ini.Write("RunAtPowerPath", Settings.RunAtPowerPath);
        }
        public static void ReadIni(string IniPath)
        {
            if (!File.Exists(IniPath)) { return; }

            IniFile ini = new IniFile(IniPath);
            Settings.Enabled = ini.Read("Enabled") == "1";
            Settings.EnableWinStart = ini.Read("EnableWinStart") == "1";
            Settings.EnableLogs = ini.Read("EnableLogs") == "1";
            Settings.RunAtStart = ini.Read("RunAtStart") == "1";
            Settings.RunAtStartPath = ini.Read("RunAtStartPath");
            Settings.RunAtPower = ini.Read("RunAtPower") == "1";
            Settings.RunAtPowerPath = ini.Read("RunAtPowerPath");
        }
        public static void SetWinStartShortcut(bool Create = true)
        {
            string shortcutDestination = Path.Combine(
                Environment.GetEnvironmentVariable("APPDATA"),
                @"Microsoft\Windows\Start Menu\Programs\Startup\SimpleTrayRunner.lnk");

            if (File.Exists(shortcutDestination)) { File.Delete(shortcutDestination); }

            if (!Create) { return; }
            Shortcut lnk = new Shortcut(Settings.Name + ".exe")
            {
                Destination = shortcutDestination,
                Description = "Start STR at Windows startup"
            };
            lnk.Save();
        }
        public static void Job(string ItemPath)
        {
            if (!File.Exists(ItemPath)) { return; }
            bool isPS1 = Path.GetExtension(ItemPath) == ".ps1";
            Process.Start(new ProcessStartInfo
            {
                FileName = isPS1 ? "powershell.exe" : ItemPath,
                Arguments = isPS1 ? $"-ep bypass -f \"{ItemPath}\"" : "",
                WorkingDirectory = Path.GetDirectoryName(ItemPath),
            });
        }
    }

    static class PowerMode
    {
        public static void TriggerEnable() => Microsoft.Win32.SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
        public static void TriggerDisable() => Microsoft.Win32.SystemEvents.PowerModeChanged -= SystemEvents_PowerModeChanged;

        public static void SystemEvents_PowerModeChanged(object sender, Microsoft.Win32.PowerModeChangedEventArgs e)
        {
            if (e.Mode == Microsoft.Win32.PowerModes.StatusChange)
            {
                Main.Log($"(Event) PowerModes.StatusChange: '{Settings.RunAtPowerPath}'");
                if (Settings.Enabled) { Main.Job(Settings.RunAtPowerPath); }
            }
            else { Main.Log("(Event) PowerModes.Resume/Suspend: ~"); }
        }
    }

    class Shortcut
    {
        public string TargetPath { get; private set; }
        public string Destination;
        public string WorkingDirectory;
        public string Description;
        public string Hotkey;
        public string IconLocation;

        public Shortcut(string Target) => TargetPath = Path.GetFullPath(Target);

        public void Resolve()
        {
            if (Destination == null)
            {
                Destination = Path.Combine(
                    Path.GetDirectoryName(TargetPath),
                    Path.GetFileNameWithoutExtension(TargetPath) + ".lnk");
            }
            if (WorkingDirectory == null) { WorkingDirectory = Path.GetDirectoryName(TargetPath); }
            if (IconLocation == null) { IconLocation = TargetPath; }
        }

        public void Save()
        {
            Resolve();

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = shell.CreateShortcut(Destination);
            shortcut.TargetPath = TargetPath;
            shortcut.WorkingDirectory = WorkingDirectory;
            shortcut.IconLocation = IconLocation;
            if (Description != null) { shortcut.Description = Description; }
            if (Hotkey != null) { shortcut.Hotkey = Hotkey; }
            shortcut.Save();
        }
    }
}
