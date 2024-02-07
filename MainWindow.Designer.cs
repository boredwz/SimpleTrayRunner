namespace SimpleTrayRunner
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayMenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsRunAtPowerPath = new System.Windows.Forms.TextBox();
            this.SettingsGroupPower = new System.Windows.Forms.GroupBox();
            this.SettingsRunAtPower = new System.Windows.Forms.CheckBox();
            this.SettingsRunAtPowerPathSelect = new System.Windows.Forms.Button();
            this.SettingsEnableWinStart = new System.Windows.Forms.CheckBox();
            this.Tab = new System.Windows.Forms.TabControl();
            this.TabHome = new System.Windows.Forms.TabPage();
            this.HomeStatus = new System.Windows.Forms.Label();
            this.HomeToggle = new System.Windows.Forms.Button();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.SettingsSave = new System.Windows.Forms.Button();
            this.SettingsEnableLogs = new System.Windows.Forms.CheckBox();
            this.SettingsGroupStartup = new System.Windows.Forms.GroupBox();
            this.SettingsRunAtStart = new System.Windows.Forms.CheckBox();
            this.SettingsRunAtStartPathSelect = new System.Windows.Forms.Button();
            this.SettingsRunAtStartPath = new System.Windows.Forms.TextBox();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.AboutAuthor = new System.Windows.Forms.GroupBox();
            this.AboutAuthorWvzxn = new System.Windows.Forms.Label();
            this.AboutAuthorLink = new System.Windows.Forms.LinkLabel();
            this.AboutInfo = new System.Windows.Forms.GroupBox();
            this.AboutInfoLink = new System.Windows.Forms.LinkLabel();
            this.AboutInfoMSDNLink = new System.Windows.Forms.LinkLabel();
            this.AboutInfoText = new System.Windows.Forms.Label();
            this.TrayMenu.SuspendLayout();
            this.SettingsGroupPower.SuspendLayout();
            this.Tab.SuspendLayout();
            this.TabHome.SuspendLayout();
            this.TabSettings.SuspendLayout();
            this.SettingsGroupStartup.SuspendLayout();
            this.TabAbout.SuspendLayout();
            this.AboutAuthor.SuspendLayout();
            this.AboutInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tray
            // 
            this.Tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tray.BalloonTipText = "STR Balloon Text";
            this.Tray.BalloonTipTitle = "STR Balloon Title";
            this.Tray.ContextMenuStrip = this.TrayMenu;
            this.Tray.Text = "Simple Tray Runner";
            this.Tray.Visible = true;
            this.Tray.DoubleClick += new System.EventHandler(this.Tray_DoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayMenuQuit});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(107, 28);
            // 
            // TrayMenuQuit
            // 
            this.TrayMenuQuit.Name = "TrayMenuQuit";
            this.TrayMenuQuit.Size = new System.Drawing.Size(106, 24);
            this.TrayMenuQuit.Text = "Quit";
            this.TrayMenuQuit.Click += new System.EventHandler(this.TrayMenuQuit_Click);
            // 
            // SettingsRunAtPowerPath
            // 
            this.SettingsRunAtPowerPath.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRunAtPowerPath.Location = new System.Drawing.Point(8, 58);
            this.SettingsRunAtPowerPath.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsRunAtPowerPath.Name = "SettingsRunAtPowerPath";
            this.SettingsRunAtPowerPath.Size = new System.Drawing.Size(400, 27);
            this.SettingsRunAtPowerPath.TabIndex = 1;
            this.SettingsRunAtPowerPath.Text = "C:\\Path\\Test";
            // 
            // SettingsGroupPower
            // 
            this.SettingsGroupPower.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsGroupPower.Controls.Add(this.SettingsRunAtPower);
            this.SettingsGroupPower.Controls.Add(this.SettingsRunAtPowerPathSelect);
            this.SettingsGroupPower.Controls.Add(this.SettingsRunAtPowerPath);
            this.SettingsGroupPower.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsGroupPower.Location = new System.Drawing.Point(9, 231);
            this.SettingsGroupPower.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsGroupPower.Name = "SettingsGroupPower";
            this.SettingsGroupPower.Padding = new System.Windows.Forms.Padding(4);
            this.SettingsGroupPower.Size = new System.Drawing.Size(476, 95);
            this.SettingsGroupPower.TabIndex = 5;
            this.SettingsGroupPower.TabStop = false;
            this.SettingsGroupPower.Text = "PowerModeChanged";
            // 
            // SettingsRunAtPower
            // 
            this.SettingsRunAtPower.AutoSize = true;
            this.SettingsRunAtPower.Checked = true;
            this.SettingsRunAtPower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SettingsRunAtPower.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRunAtPower.Location = new System.Drawing.Point(7, 27);
            this.SettingsRunAtPower.Name = "SettingsRunAtPower";
            this.SettingsRunAtPower.Size = new System.Drawing.Size(292, 24);
            this.SettingsRunAtPower.TabIndex = 7;
            this.SettingsRunAtPower.Text = "Run on PowerModeChanged event";
            this.SettingsRunAtPower.UseVisualStyleBackColor = true;
            // 
            // SettingsRunAtPowerPathSelect
            // 
            this.SettingsRunAtPowerPathSelect.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRunAtPowerPathSelect.Location = new System.Drawing.Point(416, 58);
            this.SettingsRunAtPowerPathSelect.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsRunAtPowerPathSelect.Name = "SettingsRunAtPowerPathSelect";
            this.SettingsRunAtPowerPathSelect.Size = new System.Drawing.Size(53, 27);
            this.SettingsRunAtPowerPathSelect.TabIndex = 3;
            this.SettingsRunAtPowerPathSelect.Text = "...";
            this.SettingsRunAtPowerPathSelect.UseVisualStyleBackColor = true;
            this.SettingsRunAtPowerPathSelect.Click += new System.EventHandler(this.SettingsRunAtPowerPathSelect_Click);
            // 
            // SettingsEnableWinStart
            // 
            this.SettingsEnableWinStart.AutoSize = true;
            this.SettingsEnableWinStart.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsEnableWinStart.Location = new System.Drawing.Point(6, 6);
            this.SettingsEnableWinStart.Name = "SettingsEnableWinStart";
            this.SettingsEnableWinStart.Size = new System.Drawing.Size(256, 24);
            this.SettingsEnableWinStart.TabIndex = 6;
            this.SettingsEnableWinStart.Text = "Start on Windows start up";
            this.SettingsEnableWinStart.UseVisualStyleBackColor = true;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TabHome);
            this.Tab.Controls.Add(this.TabSettings);
            this.Tab.Controls.Add(this.TabAbout);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(502, 400);
            this.Tab.TabIndex = 8;
            // 
            // TabHome
            // 
            this.TabHome.BackColor = System.Drawing.Color.Transparent;
            this.TabHome.Controls.Add(this.HomeStatus);
            this.TabHome.Controls.Add(this.HomeToggle);
            this.TabHome.Location = new System.Drawing.Point(4, 29);
            this.TabHome.Name = "TabHome";
            this.TabHome.Padding = new System.Windows.Forms.Padding(3);
            this.TabHome.Size = new System.Drawing.Size(494, 367);
            this.TabHome.TabIndex = 0;
            this.TabHome.Text = "Home";
            // 
            // HomeStatus
            // 
            this.HomeStatus.AutoSize = true;
            this.HomeStatus.Location = new System.Drawing.Point(127, 109);
            this.HomeStatus.Name = "HomeStatus";
            this.HomeStatus.Size = new System.Drawing.Size(153, 20);
            this.HomeStatus.TabIndex = 1;
            this.HomeStatus.Text = "Status: Disabled";
            // 
            // HomeToggle
            // 
            this.HomeToggle.BackColor = System.Drawing.Color.Transparent;
            this.HomeToggle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeToggle.Location = new System.Drawing.Point(131, 132);
            this.HomeToggle.Name = "HomeToggle";
            this.HomeToggle.Size = new System.Drawing.Size(207, 51);
            this.HomeToggle.TabIndex = 0;
            this.HomeToggle.Text = "Toggle";
            this.HomeToggle.UseVisualStyleBackColor = false;
            this.HomeToggle.Click += new System.EventHandler(this.HomeToggle_Click);
            // 
            // TabSettings
            // 
            this.TabSettings.BackColor = System.Drawing.Color.Transparent;
            this.TabSettings.Controls.Add(this.SettingsSave);
            this.TabSettings.Controls.Add(this.SettingsEnableLogs);
            this.TabSettings.Controls.Add(this.SettingsEnableWinStart);
            this.TabSettings.Controls.Add(this.SettingsGroupStartup);
            this.TabSettings.Controls.Add(this.SettingsGroupPower);
            this.TabSettings.Location = new System.Drawing.Point(4, 29);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabSettings.Size = new System.Drawing.Size(494, 367);
            this.TabSettings.TabIndex = 1;
            this.TabSettings.Text = "Settings";
            // 
            // SettingsSave
            // 
            this.SettingsSave.Location = new System.Drawing.Point(385, 333);
            this.SettingsSave.Name = "SettingsSave";
            this.SettingsSave.Size = new System.Drawing.Size(101, 28);
            this.SettingsSave.TabIndex = 8;
            this.SettingsSave.Text = "Save";
            this.SettingsSave.UseVisualStyleBackColor = true;
            this.SettingsSave.Click += new System.EventHandler(this.SettingsSave_Click);
            // 
            // SettingsEnableLogs
            // 
            this.SettingsEnableLogs.AutoSize = true;
            this.SettingsEnableLogs.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsEnableLogs.Location = new System.Drawing.Point(6, 36);
            this.SettingsEnableLogs.Name = "SettingsEnableLogs";
            this.SettingsEnableLogs.Size = new System.Drawing.Size(130, 24);
            this.SettingsEnableLogs.TabIndex = 7;
            this.SettingsEnableLogs.Text = "Enable Logs";
            this.SettingsEnableLogs.UseVisualStyleBackColor = true;
            // 
            // SettingsGroupStartup
            // 
            this.SettingsGroupStartup.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsGroupStartup.Controls.Add(this.SettingsRunAtStart);
            this.SettingsGroupStartup.Controls.Add(this.SettingsRunAtStartPathSelect);
            this.SettingsGroupStartup.Controls.Add(this.SettingsRunAtStartPath);
            this.SettingsGroupStartup.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsGroupStartup.Location = new System.Drawing.Point(9, 127);
            this.SettingsGroupStartup.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsGroupStartup.Name = "SettingsGroupStartup";
            this.SettingsGroupStartup.Padding = new System.Windows.Forms.Padding(4);
            this.SettingsGroupStartup.Size = new System.Drawing.Size(476, 96);
            this.SettingsGroupStartup.TabIndex = 6;
            this.SettingsGroupStartup.TabStop = false;
            this.SettingsGroupStartup.Text = "Startup";
            // 
            // SettingsRunAtStart
            // 
            this.SettingsRunAtStart.AutoSize = true;
            this.SettingsRunAtStart.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRunAtStart.Location = new System.Drawing.Point(7, 27);
            this.SettingsRunAtStart.Name = "SettingsRunAtStart";
            this.SettingsRunAtStart.Size = new System.Drawing.Size(175, 24);
            this.SettingsRunAtStart.TabIndex = 6;
            this.SettingsRunAtStart.Text = "Run on STR start";
            this.SettingsRunAtStart.UseVisualStyleBackColor = true;
            // 
            // SettingsRunAtStartPathSelect
            // 
            this.SettingsRunAtStartPathSelect.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRunAtStartPathSelect.Location = new System.Drawing.Point(420, 58);
            this.SettingsRunAtStartPathSelect.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsRunAtStartPathSelect.Name = "SettingsRunAtStartPathSelect";
            this.SettingsRunAtStartPathSelect.Size = new System.Drawing.Size(49, 27);
            this.SettingsRunAtStartPathSelect.TabIndex = 3;
            this.SettingsRunAtStartPathSelect.Text = "...";
            this.SettingsRunAtStartPathSelect.UseVisualStyleBackColor = true;
            this.SettingsRunAtStartPathSelect.Click += new System.EventHandler(this.SettingsRunAtStartPathSelect_Click);
            // 
            // SettingsRunAtStartPath
            // 
            this.SettingsRunAtStartPath.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRunAtStartPath.Location = new System.Drawing.Point(8, 58);
            this.SettingsRunAtStartPath.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsRunAtStartPath.Name = "SettingsRunAtStartPath";
            this.SettingsRunAtStartPath.Size = new System.Drawing.Size(404, 27);
            this.SettingsRunAtStartPath.TabIndex = 1;
            this.SettingsRunAtStartPath.Text = "C:\\Path\\Test";
            // 
            // TabAbout
            // 
            this.TabAbout.BackColor = System.Drawing.Color.Transparent;
            this.TabAbout.Controls.Add(this.AboutAuthor);
            this.TabAbout.Controls.Add(this.AboutInfo);
            this.TabAbout.Location = new System.Drawing.Point(4, 29);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabAbout.Size = new System.Drawing.Size(494, 367);
            this.TabAbout.TabIndex = 2;
            this.TabAbout.Text = "About";
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Controls.Add(this.AboutAuthorWvzxn);
            this.AboutAuthor.Controls.Add(this.AboutAuthorLink);
            this.AboutAuthor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutAuthor.Location = new System.Drawing.Point(8, 241);
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.Size = new System.Drawing.Size(92, 118);
            this.AboutAuthor.TabIndex = 7;
            this.AboutAuthor.TabStop = false;
            this.AboutAuthor.Text = "Author";
            // 
            // AboutAuthorWvzxn
            // 
            this.AboutAuthorWvzxn.Location = new System.Drawing.Point(6, 23);
            this.AboutAuthorWvzxn.Name = "AboutAuthorWvzxn";
            this.AboutAuthorWvzxn.Size = new System.Drawing.Size(77, 33);
            this.AboutAuthorWvzxn.TabIndex = 6;
            this.AboutAuthorWvzxn.Text = "wvzxn";
            this.AboutAuthorWvzxn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AboutAuthorLink
            // 
            this.AboutAuthorLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AboutAuthorLink.Location = new System.Drawing.Point(6, 56);
            this.AboutAuthorLink.Name = "AboutAuthorLink";
            this.AboutAuthorLink.Size = new System.Drawing.Size(77, 51);
            this.AboutAuthorLink.TabIndex = 5;
            this.AboutAuthorLink.TabStop = true;
            this.AboutAuthorLink.Text = "GitHub";
            this.AboutAuthorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutAuthorLink_LinkClicked);
            // 
            // AboutInfo
            // 
            this.AboutInfo.Controls.Add(this.AboutInfoLink);
            this.AboutInfo.Controls.Add(this.AboutInfoMSDNLink);
            this.AboutInfo.Controls.Add(this.AboutInfoText);
            this.AboutInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutInfo.Location = new System.Drawing.Point(7, 7);
            this.AboutInfo.Margin = new System.Windows.Forms.Padding(4);
            this.AboutInfo.Name = "AboutInfo";
            this.AboutInfo.Padding = new System.Windows.Forms.Padding(4);
            this.AboutInfo.Size = new System.Drawing.Size(477, 227);
            this.AboutInfo.TabIndex = 5;
            this.AboutInfo.TabStop = false;
            this.AboutInfo.Text = "Info";
            // 
            // AboutInfoLink
            // 
            this.AboutInfoLink.AutoSize = true;
            this.AboutInfoLink.Location = new System.Drawing.Point(7, 112);
            this.AboutInfoLink.Name = "AboutInfoLink";
            this.AboutInfoLink.Size = new System.Drawing.Size(171, 20);
            this.AboutInfoLink.TabIndex = 5;
            this.AboutInfoLink.TabStop = true;
            this.AboutInfoLink.Text = "More Info (GitHub)";
            this.AboutInfoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutInfoLink_LinkClicked);
            // 
            // AboutInfoMSDNLink
            // 
            this.AboutInfoMSDNLink.AutoSize = true;
            this.AboutInfoMSDNLink.Location = new System.Drawing.Point(75, 203);
            this.AboutInfoMSDNLink.Name = "AboutInfoMSDNLink";
            this.AboutInfoMSDNLink.Size = new System.Drawing.Size(387, 20);
            this.AboutInfoMSDNLink.TabIndex = 4;
            this.AboutInfoMSDNLink.TabStop = true;
            this.AboutInfoMSDNLink.Text = "SystemEvents.PowerModeChanged Event - MSDN";
            this.AboutInfoMSDNLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutInfoMSDNLink_LinkClicked);
            // 
            // AboutInfoText
            // 
            this.AboutInfoText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutInfoText.Location = new System.Drawing.Point(4, 23);
            this.AboutInfoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutInfoText.Name = "AboutInfoText";
            this.AboutInfoText.Size = new System.Drawing.Size(458, 89);
            this.AboutInfoText.TabIndex = 3;
            this.AboutInfoText.Text = "SystemEvents.PowerModeChanged is used to detect AC/DC battery state.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 400);
            this.Controls.Add(this.Tab);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(42, 47);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Tray Runner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.TrayMenu.ResumeLayout(false);
            this.SettingsGroupPower.ResumeLayout(false);
            this.SettingsGroupPower.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.TabHome.ResumeLayout(false);
            this.TabHome.PerformLayout();
            this.TabSettings.ResumeLayout(false);
            this.TabSettings.PerformLayout();
            this.SettingsGroupStartup.ResumeLayout(false);
            this.SettingsGroupStartup.PerformLayout();
            this.TabAbout.ResumeLayout(false);
            this.AboutAuthor.ResumeLayout(false);
            this.AboutInfo.ResumeLayout(false);
            this.AboutInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayMenuQuit;
        private System.Windows.Forms.TextBox SettingsRunAtPowerPath;
        private System.Windows.Forms.GroupBox SettingsGroupPower;
        private System.Windows.Forms.Button SettingsRunAtPowerPathSelect;
        private System.Windows.Forms.CheckBox SettingsEnableWinStart;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage TabHome;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.Button HomeToggle;
        private System.Windows.Forms.Label HomeStatus;
        private System.Windows.Forms.TabPage TabAbout;
        private System.Windows.Forms.GroupBox SettingsGroupStartup;
        private System.Windows.Forms.Button SettingsRunAtStartPathSelect;
        private System.Windows.Forms.TextBox SettingsRunAtStartPath;
        private System.Windows.Forms.GroupBox AboutInfo;
        private System.Windows.Forms.GroupBox AboutAuthor;
        private System.Windows.Forms.Label AboutAuthorWvzxn;
        private System.Windows.Forms.LinkLabel AboutAuthorLink;
        private System.Windows.Forms.LinkLabel AboutInfoMSDNLink;
        private System.Windows.Forms.Label AboutInfoText;
        private System.Windows.Forms.CheckBox SettingsRunAtPower;
        private System.Windows.Forms.CheckBox SettingsRunAtStart;
        private System.Windows.Forms.LinkLabel AboutInfoLink;
        private System.Windows.Forms.CheckBox SettingsEnableLogs;
        private System.Windows.Forms.Button SettingsSave;
    }
}

