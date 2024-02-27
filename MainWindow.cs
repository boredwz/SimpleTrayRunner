using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SimpleTrayRunner
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            StartInit();
        }

        void StartInit()
        {
            // MainWindow: set icon, title, settings
            Icon = Tray.Icon = Properties.Resources.favicon;
            Text += " v" + Application.ProductVersion;
            SyncSettingsForm();

            if (!File.Exists(Settings.Ini)) { return; }

            // Read from INI, write to Settings
            Main.ReadIni(Settings.Ini);
            SyncSettingsForm();

            Main.Log("(App) Start");

            // Home Toggle: change status, color + log
            Home_Set(Settings.Enabled);

            // (Event) Startup
            if (Settings.RunAtStart && Settings.Enabled)
            {
                Main.Log($"(Event) Startup: '{Settings.RunAtStartPath}'");
                Main.Job(Settings.RunAtStartPath);
            }
            
        }

        //  Refresh Settings
        void SyncSettingsClass() // Checkbox, Textbox fields => Var
        {
            Settings.EnableWinStart = SettingsEnableWinStart.Checked;
            Settings.EnableLogs = SettingsEnableLogs.Checked;
            Settings.RunAtStart = SettingsRunAtStart.Checked;
            Settings.RunAtStartPath = SettingsRunAtStartPath.Text;
            Settings.RunAtPower = SettingsRunAtPower.Checked;
            Settings.RunAtPowerPath = SettingsRunAtPowerPath.Text;
        }
        void SyncSettingsForm() // Var => Checkbox, Textbox fields
        {
            SettingsEnableWinStart.Checked = Settings.EnableWinStart;
            SettingsEnableLogs.Checked = Settings.EnableLogs;
            SettingsRunAtStart.Checked = Settings.RunAtStart;
            SettingsRunAtStartPath.Text = Settings.RunAtStartPath;
            SettingsRunAtPower.Checked = Settings.RunAtPower;
            SettingsRunAtPowerPath.Text = Settings.RunAtPowerPath;
        }

        

        //  MainWindow (Hide to tray)
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) // Hide instead closing
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Hide();
                Tray.Visible = true;
                e.Cancel = true;
            }
        }
        private void MainWindow_Shown(object sender, EventArgs e) // Hide at startup
        {
            if (Settings.Enabled)
            {
                Hide();
                Tray.Visible = true;
            }
        }

        //  Tray
        private void Tray_DoubleClick(object Sender, EventArgs e) { Show(); Tray.Visible = false; }
        private void TrayMenuQuit_Click(object sender, EventArgs e) { Main.Log("(App) Quit"); Application.Exit(); }



        //  [HOME]
        private void HomeToggle_Click(object sender, EventArgs e) => Home_Toggle();
        private void Home_Toggle() => Home_Set(!Settings.Enabled, true);
        private void Home_Set(bool enable, bool toggle = false)
        {
            Settings.Enabled = enable;
            string status = Settings.Enabled ? "Enabled" : "Disabled";
            HomeToggle.BackColor = Settings.Enabled ? System.Drawing.Color.PaleGreen : System.Drawing.Color.Transparent;
            HomeStatus.Text = $"Status: {status}";
            Main.Log($"(Status) {status}");

            // PowerMode trigger (Enable/Disable)
            if (Settings.RunAtPower && Settings.Enabled)
            {
                if (Settings.Enabled) { PowerMode.TriggerEnable(); }
                else { PowerMode.TriggerDisable(); }
            }

            // If Home Toggle button pressed
            if (toggle)
            {
                Main.Log("(INI) Home button, saving settings..");
                Main.WriteIni(Settings.Ini);
            }
        }

        //  [SAVE]
        private void SettingsSave_Click(object sender, EventArgs e)
        {
            SyncSettingsClass();
            Main.SetWinStartShortcut(Settings.EnableWinStart);
            Main.Log("(INI) Save button, saving settings..");
            Main.WriteIni(Settings.Ini);
        }



        //  Links
        private void AboutInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/wvzxn/SimpleTrayRunner");
        }
        private void AboutInfoMSDNLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://learn.microsoft.com/en-us/dotnet/api/microsoft.win32.systemevents.powermodechanged?view=netframework-4.5.2");
        }
        private void AboutAuthorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/wvzxn");
        }

        //  Choose files Dialog
        private void SettingsRunAtStartPathSelect_Click(object sender, EventArgs e)
        {
            string dialogPath = Main.GetOpenFileDialogPath();
            if (dialogPath != null)
            {
                Settings.RunAtStartPath = dialogPath;
                SyncSettingsForm();
            }
        }
        private void SettingsRunAtPowerPathSelect_Click(object sender, EventArgs e)
        {
            string dialogPath = Main.GetOpenFileDialogPath();
            if (dialogPath != null)
            {
                Settings.RunAtPowerPath = dialogPath;
                SyncSettingsForm();
            }
        }
    }
}
