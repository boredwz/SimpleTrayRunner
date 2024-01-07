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
            this.WorkPath = new System.Windows.Forms.TextBox();
            this.WorkPathText = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.PanelGroupInfo = new System.Windows.Forms.GroupBox();
            this.InfoTextMSDNLink = new System.Windows.Forms.LinkLabel();
            this.PanelGroupSettings = new System.Windows.Forms.GroupBox();
            this.CheckBoxEnableExclude = new System.Windows.Forms.CheckBox();
            this.CheckBoxEnableScripts = new System.Windows.Forms.CheckBox();
            this.WorkPathButtonOK = new System.Windows.Forms.Button();
            this.InfoTextGitHubLink = new System.Windows.Forms.LinkLabel();
            this.PanelGroupAuthor = new System.Windows.Forms.GroupBox();
            this.InfoTextAuthorLabel = new System.Windows.Forms.Label();
            this.CheckBoxEnableAutoStart = new System.Windows.Forms.CheckBox();
            this.TrayMenu.SuspendLayout();
            this.PanelGroupInfo.SuspendLayout();
            this.PanelGroupSettings.SuspendLayout();
            this.PanelGroupAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tray
            // 
            this.Tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tray.BalloonTipText = "Balloon Text";
            this.Tray.BalloonTipTitle = "Balloon Title";
            this.Tray.ContextMenuStrip = this.TrayMenu;
            this.Tray.Text = "Text";
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
            // WorkPath
            // 
            this.WorkPath.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkPath.Location = new System.Drawing.Point(12, 172);
            this.WorkPath.Margin = new System.Windows.Forms.Padding(4);
            this.WorkPath.Name = "WorkPath";
            this.WorkPath.Size = new System.Drawing.Size(406, 27);
            this.WorkPath.TabIndex = 1;
            this.WorkPath.Text = "C:\\Path\\Test";
            // 
            // WorkPathText
            // 
            this.WorkPathText.AutoSize = true;
            this.WorkPathText.Location = new System.Drawing.Point(8, 148);
            this.WorkPathText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkPathText.Name = "WorkPathText";
            this.WorkPathText.Size = new System.Drawing.Size(54, 20);
            this.WorkPathText.TabIndex = 2;
            this.WorkPathText.Text = "Path:";
            // 
            // InfoText
            // 
            this.InfoText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.Location = new System.Drawing.Point(4, 23);
            this.InfoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(397, 127);
            this.InfoText.TabIndex = 3;
            this.InfoText.Text = "This app checks for SystemEvents.PowerModeChanged Event triggered.\r\nIf a folder i" +
    "s specified, all files inside will be launched.";
            // 
            // PanelGroupInfo
            // 
            this.PanelGroupInfo.Controls.Add(this.PanelGroupAuthor);
            this.PanelGroupInfo.Controls.Add(this.InfoTextMSDNLink);
            this.PanelGroupInfo.Controls.Add(this.InfoText);
            this.PanelGroupInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelGroupInfo.Location = new System.Drawing.Point(13, 15);
            this.PanelGroupInfo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelGroupInfo.Name = "PanelGroupInfo";
            this.PanelGroupInfo.Padding = new System.Windows.Forms.Padding(4);
            this.PanelGroupInfo.Size = new System.Drawing.Size(540, 227);
            this.PanelGroupInfo.TabIndex = 4;
            this.PanelGroupInfo.TabStop = false;
            this.PanelGroupInfo.Text = "Info";
            // 
            // InfoTextMSDNLink
            // 
            this.InfoTextMSDNLink.AutoSize = true;
            this.InfoTextMSDNLink.Location = new System.Drawing.Point(145, 203);
            this.InfoTextMSDNLink.Name = "InfoTextMSDNLink";
            this.InfoTextMSDNLink.Size = new System.Drawing.Size(387, 20);
            this.InfoTextMSDNLink.TabIndex = 4;
            this.InfoTextMSDNLink.TabStop = true;
            this.InfoTextMSDNLink.Text = "SystemEvents.PowerModeChanged Event - MSDN";
            this.InfoTextMSDNLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InfoTextMSDNLink_LinkClicked);
            // 
            // PanelGroupSettings
            // 
            this.PanelGroupSettings.BackColor = System.Drawing.SystemColors.Control;
            this.PanelGroupSettings.Controls.Add(this.CheckBoxEnableAutoStart);
            this.PanelGroupSettings.Controls.Add(this.CheckBoxEnableExclude);
            this.PanelGroupSettings.Controls.Add(this.CheckBoxEnableScripts);
            this.PanelGroupSettings.Controls.Add(this.WorkPathButtonOK);
            this.PanelGroupSettings.Controls.Add(this.WorkPathText);
            this.PanelGroupSettings.Controls.Add(this.WorkPath);
            this.PanelGroupSettings.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelGroupSettings.Location = new System.Drawing.Point(13, 249);
            this.PanelGroupSettings.Margin = new System.Windows.Forms.Padding(4);
            this.PanelGroupSettings.Name = "PanelGroupSettings";
            this.PanelGroupSettings.Padding = new System.Windows.Forms.Padding(4);
            this.PanelGroupSettings.Size = new System.Drawing.Size(540, 207);
            this.PanelGroupSettings.TabIndex = 5;
            this.PanelGroupSettings.TabStop = false;
            this.PanelGroupSettings.Text = "Settings";
            // 
            // CheckBoxEnableExclude
            // 
            this.CheckBoxEnableExclude.AutoSize = true;
            this.CheckBoxEnableExclude.Checked = true;
            this.CheckBoxEnableExclude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEnableExclude.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxEnableExclude.Location = new System.Drawing.Point(12, 58);
            this.CheckBoxEnableExclude.Name = "CheckBoxEnableExclude";
            this.CheckBoxEnableExclude.Size = new System.Drawing.Size(382, 24);
            this.CheckBoxEnableExclude.TabIndex = 5;
            this.CheckBoxEnableExclude.Text = "Don\'t execute files that start with \'#\'";
            this.CheckBoxEnableExclude.UseVisualStyleBackColor = true;
            this.CheckBoxEnableExclude.CheckedChanged += new System.EventHandler(this.CheckBoxEnableExclude_CheckedChanged);
            // 
            // CheckBoxEnableScripts
            // 
            this.CheckBoxEnableScripts.AutoSize = true;
            this.CheckBoxEnableScripts.Checked = true;
            this.CheckBoxEnableScripts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEnableScripts.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxEnableScripts.Location = new System.Drawing.Point(12, 28);
            this.CheckBoxEnableScripts.Name = "CheckBoxEnableScripts";
            this.CheckBoxEnableScripts.Size = new System.Drawing.Size(454, 24);
            this.CheckBoxEnableScripts.TabIndex = 4;
            this.CheckBoxEnableScripts.Text = "Enable executing .ps1 .cmd .bat .vbs .lnk files";
            this.CheckBoxEnableScripts.UseVisualStyleBackColor = true;
            this.CheckBoxEnableScripts.CheckedChanged += new System.EventHandler(this.CheckBoxEnableScripts_CheckedChanged);
            // 
            // WorkPathButtonOK
            // 
            this.WorkPathButtonOK.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkPathButtonOK.Location = new System.Drawing.Point(426, 172);
            this.WorkPathButtonOK.Margin = new System.Windows.Forms.Padding(4);
            this.WorkPathButtonOK.Name = "WorkPathButtonOK";
            this.WorkPathButtonOK.Size = new System.Drawing.Size(106, 27);
            this.WorkPathButtonOK.TabIndex = 3;
            this.WorkPathButtonOK.Text = "Save";
            this.WorkPathButtonOK.UseVisualStyleBackColor = true;
            this.WorkPathButtonOK.Click += new System.EventHandler(this.ScriptPathButtonOK_Click);
            // 
            // InfoTextGitHubLink
            // 
            this.InfoTextGitHubLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoTextGitHubLink.Location = new System.Drawing.Point(6, 56);
            this.InfoTextGitHubLink.Name = "InfoTextGitHubLink";
            this.InfoTextGitHubLink.Size = new System.Drawing.Size(112, 43);
            this.InfoTextGitHubLink.TabIndex = 5;
            this.InfoTextGitHubLink.TabStop = true;
            this.InfoTextGitHubLink.Text = "GitHub";
            this.InfoTextGitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InfoTextGitHubLink_LinkClicked);
            // 
            // PanelGroupAuthor
            // 
            this.PanelGroupAuthor.Controls.Add(this.InfoTextAuthorLabel);
            this.PanelGroupAuthor.Controls.Add(this.InfoTextGitHubLink);
            this.PanelGroupAuthor.Location = new System.Drawing.Point(408, 23);
            this.PanelGroupAuthor.Name = "PanelGroupAuthor";
            this.PanelGroupAuthor.Size = new System.Drawing.Size(124, 102);
            this.PanelGroupAuthor.TabIndex = 7;
            this.PanelGroupAuthor.TabStop = false;
            this.PanelGroupAuthor.Text = "Author";
            // 
            // InfoTextAuthorLabel
            // 
            this.InfoTextAuthorLabel.Location = new System.Drawing.Point(6, 23);
            this.InfoTextAuthorLabel.Name = "InfoTextAuthorLabel";
            this.InfoTextAuthorLabel.Size = new System.Drawing.Size(112, 33);
            this.InfoTextAuthorLabel.TabIndex = 6;
            this.InfoTextAuthorLabel.Text = "wvzxn";
            this.InfoTextAuthorLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CheckBoxEnableAutoStart
            // 
            this.CheckBoxEnableAutoStart.AutoSize = true;
            this.CheckBoxEnableAutoStart.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxEnableAutoStart.Location = new System.Drawing.Point(12, 89);
            this.CheckBoxEnableAutoStart.Name = "CheckBoxEnableAutoStart";
            this.CheckBoxEnableAutoStart.Size = new System.Drawing.Size(256, 24);
            this.CheckBoxEnableAutoStart.TabIndex = 6;
            this.CheckBoxEnableAutoStart.Text = "Start on Windows start up";
            this.CheckBoxEnableAutoStart.UseVisualStyleBackColor = true;
            this.CheckBoxEnableAutoStart.CheckedChanged += new System.EventHandler(this.CheckBoxEnableAutoStart_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 469);
            this.Controls.Add(this.PanelGroupSettings);
            this.Controls.Add(this.PanelGroupInfo);
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
            this.PanelGroupInfo.ResumeLayout(false);
            this.PanelGroupInfo.PerformLayout();
            this.PanelGroupSettings.ResumeLayout(false);
            this.PanelGroupSettings.PerformLayout();
            this.PanelGroupAuthor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayMenuQuit;
        private System.Windows.Forms.TextBox WorkPath;
        private System.Windows.Forms.Label WorkPathText;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.GroupBox PanelGroupInfo;
        private System.Windows.Forms.GroupBox PanelGroupSettings;
        private System.Windows.Forms.Button WorkPathButtonOK;
        private System.Windows.Forms.CheckBox CheckBoxEnableExclude;
        private System.Windows.Forms.CheckBox CheckBoxEnableScripts;
        private System.Windows.Forms.LinkLabel InfoTextMSDNLink;
        private System.Windows.Forms.GroupBox PanelGroupAuthor;
        private System.Windows.Forms.LinkLabel InfoTextGitHubLink;
        private System.Windows.Forms.Label InfoTextAuthorLabel;
        private System.Windows.Forms.CheckBox CheckBoxEnableAutoStart;
    }
}

