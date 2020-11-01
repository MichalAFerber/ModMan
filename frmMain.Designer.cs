namespace ModMan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbModFolder = new System.Windows.Forms.ListBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.txtModFolder = new System.Windows.Forms.TextBox();
            this.txtSettingsFolder = new System.Windows.Forms.TextBox();
            this.txtAppFolder = new System.Windows.Forms.TextBox();
            this.btnSettingsFolder = new System.Windows.Forms.Button();
            this.btnModFolder = new System.Windows.Forms.Button();
            this.btnAppFolder = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.gbModFolder = new System.Windows.Forms.GroupBox();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.gbAdvancedSettings = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAdancedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewSettings = new System.Windows.Forms.Button();
            this.btnViewGameSettings = new System.Windows.Forms.Button();
            this.llAppFolder = new System.Windows.Forms.LinkLabel();
            this.llSettingsFolder = new System.Windows.Forms.LinkLabel();
            this.llModFolder = new System.Windows.Forms.LinkLabel();
            this.chkSettingsDevelopment = new System.Windows.Forms.CheckBox();
            this.chkSettingsAudio = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudsettingsAudioVolume = new System.Windows.Forms.NumericUpDown();
            this.lblVolume = new System.Windows.Forms.Label();
            this.chkSettingsLogging = new System.Windows.Forms.CheckBox();
            this.txtSettingsLogFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.gbSettings.SuspendLayout();
            this.gbModFolder.SuspendLayout();
            this.gbAdvancedSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsettingsAudioVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lbModFolder
            // 
            this.lbModFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModFolder.FormattingEnabled = true;
            this.lbModFolder.ItemHeight = 16;
            this.lbModFolder.Location = new System.Drawing.Point(4, 19);
            this.lbModFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbModFolder.Name = "lbModFolder";
            this.lbModFolder.Size = new System.Drawing.Size(736, 217);
            this.lbModFolder.TabIndex = 0;
            this.lbModFolder.Click += new System.EventHandler(this.lbModFolder_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.llModFolder);
            this.gbSettings.Controls.Add(this.llSettingsFolder);
            this.gbSettings.Controls.Add(this.llAppFolder);
            this.gbSettings.Controls.Add(this.txtModFolder);
            this.gbSettings.Controls.Add(this.txtSettingsFolder);
            this.gbSettings.Controls.Add(this.txtAppFolder);
            this.gbSettings.Controls.Add(this.btnSettingsFolder);
            this.gbSettings.Controls.Add(this.btnModFolder);
            this.gbSettings.Controls.Add(this.btnAppFolder);
            this.gbSettings.Location = new System.Drawing.Point(16, 33);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSettings.Size = new System.Drawing.Size(744, 130);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // txtModFolder
            // 
            this.txtModFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModFolder.Location = new System.Drawing.Point(196, 97);
            this.txtModFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModFolder.Name = "txtModFolder";
            this.txtModFolder.ReadOnly = true;
            this.txtModFolder.Size = new System.Drawing.Size(520, 22);
            this.txtModFolder.TabIndex = 5;
            this.txtModFolder.Text = "C:\\Users\\%username%\\Documents\\My Games\\FarmingSimulator2019\\mods";
            this.txtModFolder.WordWrap = false;
            // 
            // txtSettingsFolder
            // 
            this.txtSettingsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSettingsFolder.Location = new System.Drawing.Point(196, 62);
            this.txtSettingsFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSettingsFolder.Name = "txtSettingsFolder";
            this.txtSettingsFolder.ReadOnly = true;
            this.txtSettingsFolder.Size = new System.Drawing.Size(520, 22);
            this.txtSettingsFolder.TabIndex = 4;
            this.txtSettingsFolder.Text = "C:\\Users\\%username%\\Documents\\My Games\\FarmingSimulator2019";
            this.txtSettingsFolder.WordWrap = false;
            // 
            // txtAppFolder
            // 
            this.txtAppFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppFolder.Location = new System.Drawing.Point(196, 26);
            this.txtAppFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAppFolder.Name = "txtAppFolder";
            this.txtAppFolder.ReadOnly = true;
            this.txtAppFolder.Size = new System.Drawing.Size(520, 22);
            this.txtAppFolder.TabIndex = 3;
            this.txtAppFolder.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Farming Simulator 19";
            this.txtAppFolder.WordWrap = false;
            // 
            // btnSettingsFolder
            // 
            this.btnSettingsFolder.Location = new System.Drawing.Point(8, 59);
            this.btnSettingsFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettingsFolder.Name = "btnSettingsFolder";
            this.btnSettingsFolder.Size = new System.Drawing.Size(180, 28);
            this.btnSettingsFolder.TabIndex = 2;
            this.btnSettingsFolder.Text = "Game Settings Folder";
            this.btnSettingsFolder.UseVisualStyleBackColor = true;
            this.btnSettingsFolder.Click += new System.EventHandler(this.btnSettingsFolder_Click);
            // 
            // btnModFolder
            // 
            this.btnModFolder.Location = new System.Drawing.Point(8, 95);
            this.btnModFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModFolder.Name = "btnModFolder";
            this.btnModFolder.Size = new System.Drawing.Size(180, 28);
            this.btnModFolder.TabIndex = 1;
            this.btnModFolder.Text = "Mod Folder Root";
            this.btnModFolder.UseVisualStyleBackColor = true;
            this.btnModFolder.Click += new System.EventHandler(this.btnModFolder_Click);
            // 
            // btnAppFolder
            // 
            this.btnAppFolder.Location = new System.Drawing.Point(8, 23);
            this.btnAppFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAppFolder.Name = "btnAppFolder";
            this.btnAppFolder.Size = new System.Drawing.Size(180, 28);
            this.btnAppFolder.TabIndex = 0;
            this.btnAppFolder.Text = "Application Folder";
            this.btnAppFolder.UseVisualStyleBackColor = true;
            this.btnAppFolder.Click += new System.EventHandler(this.btnAppFolder_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayGame.Location = new System.Drawing.Point(580, 524);
            this.btnPlayGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(180, 28);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // gbModFolder
            // 
            this.gbModFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbModFolder.Controls.Add(this.lbModFolder);
            this.gbModFolder.Location = new System.Drawing.Point(16, 277);
            this.gbModFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbModFolder.Name = "gbModFolder";
            this.gbModFolder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbModFolder.Size = new System.Drawing.Size(744, 240);
            this.gbModFolder.TabIndex = 2;
            this.gbModFolder.TabStop = false;
            this.gbModFolder.Text = "Mod Folder to Use";
            // 
            // btnViewLog
            // 
            this.btnViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewLog.Location = new System.Drawing.Point(16, 524);
            this.btnViewLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(180, 28);
            this.btnViewLog.TabIndex = 3;
            this.btnViewLog.Text = "View Application Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // gbAdvancedSettings
            // 
            this.gbAdvancedSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdvancedSettings.Controls.Add(this.groupBox2);
            this.gbAdvancedSettings.Controls.Add(this.groupBox1);
            this.gbAdvancedSettings.Controls.Add(this.chkSettingsDevelopment);
            this.gbAdvancedSettings.Location = new System.Drawing.Point(16, 171);
            this.gbAdvancedSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdvancedSettings.Name = "gbAdvancedSettings";
            this.gbAdvancedSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdvancedSettings.Size = new System.Drawing.Size(744, 98);
            this.gbAdvancedSettings.TabIndex = 4;
            this.gbAdvancedSettings.TabStop = false;
            this.gbAdvancedSettings.Text = "Advanced Settings (game.xml)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(776, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAdancedSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // showAdancedSettingsToolStripMenuItem
            // 
            this.showAdancedSettingsToolStripMenuItem.CheckOnClick = true;
            this.showAdancedSettingsToolStripMenuItem.Name = "showAdancedSettingsToolStripMenuItem";
            this.showAdancedSettingsToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.showAdancedSettingsToolStripMenuItem.Text = "Show Adanced Settings";
            this.showAdancedSettingsToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.showAdancedSettingsToolStripMenuItem_CheckStateChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnViewSettings
            // 
            this.btnViewSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewSettings.Location = new System.Drawing.Point(204, 524);
            this.btnViewSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewSettings.Name = "btnViewSettings";
            this.btnViewSettings.Size = new System.Drawing.Size(180, 28);
            this.btnViewSettings.TabIndex = 6;
            this.btnViewSettings.Text = "View Settings XML";
            this.btnViewSettings.UseVisualStyleBackColor = true;
            this.btnViewSettings.Click += new System.EventHandler(this.btnViewSettings_Click);
            // 
            // btnViewGameSettings
            // 
            this.btnViewGameSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewGameSettings.Location = new System.Drawing.Point(392, 524);
            this.btnViewGameSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewGameSettings.Name = "btnViewGameSettings";
            this.btnViewGameSettings.Size = new System.Drawing.Size(180, 28);
            this.btnViewGameSettings.TabIndex = 7;
            this.btnViewGameSettings.Text = "View Game Settings XML";
            this.btnViewGameSettings.UseVisualStyleBackColor = true;
            this.btnViewGameSettings.Click += new System.EventHandler(this.btnViewGameSettings_Click);
            // 
            // llAppFolder
            // 
            this.llAppFolder.AutoSize = true;
            this.llAppFolder.Location = new System.Drawing.Point(713, 29);
            this.llAppFolder.Name = "llAppFolder";
            this.llAppFolder.Size = new System.Drawing.Size(20, 17);
            this.llAppFolder.TabIndex = 6;
            this.llAppFolder.TabStop = true;
            this.llAppFolder.Text = "...";
            this.llAppFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAppFolder_LinkClicked);
            // 
            // llSettingsFolder
            // 
            this.llSettingsFolder.AutoSize = true;
            this.llSettingsFolder.Location = new System.Drawing.Point(713, 65);
            this.llSettingsFolder.Name = "llSettingsFolder";
            this.llSettingsFolder.Size = new System.Drawing.Size(20, 17);
            this.llSettingsFolder.TabIndex = 7;
            this.llSettingsFolder.TabStop = true;
            this.llSettingsFolder.Text = "...";
            this.llSettingsFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSettingsFolder_LinkClicked);
            // 
            // llModFolder
            // 
            this.llModFolder.AutoSize = true;
            this.llModFolder.Location = new System.Drawing.Point(713, 100);
            this.llModFolder.Name = "llModFolder";
            this.llModFolder.Size = new System.Drawing.Size(20, 17);
            this.llModFolder.TabIndex = 8;
            this.llModFolder.TabStop = true;
            this.llModFolder.Text = "...";
            this.llModFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llModFolder_LinkClicked);
            // 
            // chkSettingsDevelopment
            // 
            this.chkSettingsDevelopment.AutoSize = true;
            this.chkSettingsDevelopment.Location = new System.Drawing.Point(8, 23);
            this.chkSettingsDevelopment.Name = "chkSettingsDevelopment";
            this.chkSettingsDevelopment.Size = new System.Drawing.Size(182, 21);
            this.chkSettingsDevelopment.TabIndex = 0;
            this.chkSettingsDevelopment.Text = "Enable Developer Mode";
            this.chkSettingsDevelopment.UseVisualStyleBackColor = true;
            this.chkSettingsDevelopment.CheckedChanged += new System.EventHandler(this.chkSettingsDevelopment_CheckedChanged);
            // 
            // chkSettingsAudio
            // 
            this.chkSettingsAudio.AutoSize = true;
            this.chkSettingsAudio.Location = new System.Drawing.Point(6, 21);
            this.chkSettingsAudio.Name = "chkSettingsAudio";
            this.chkSettingsAudio.Size = new System.Drawing.Size(74, 21);
            this.chkSettingsAudio.TabIndex = 1;
            this.chkSettingsAudio.Text = "Enable";
            this.chkSettingsAudio.UseVisualStyleBackColor = true;
            this.chkSettingsAudio.CheckedChanged += new System.EventHandler(this.chkSettingsAudio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFilename);
            this.groupBox1.Controls.Add(this.txtSettingsLogFilename);
            this.groupBox1.Controls.Add(this.chkSettingsLogging);
            this.groupBox1.Location = new System.Drawing.Point(412, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logging";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVolume);
            this.groupBox2.Controls.Add(this.nudsettingsAudioVolume);
            this.groupBox2.Controls.Add(this.chkSettingsAudio);
            this.groupBox2.Location = new System.Drawing.Point(216, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // nudsettingsAudioVolume
            // 
            this.nudsettingsAudioVolume.DecimalPlaces = 4;
            this.nudsettingsAudioVolume.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            262144});
            this.nudsettingsAudioVolume.Location = new System.Drawing.Point(6, 48);
            this.nudsettingsAudioVolume.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            262144});
            this.nudsettingsAudioVolume.Name = "nudsettingsAudioVolume";
            this.nudsettingsAudioVolume.Size = new System.Drawing.Size(74, 22);
            this.nudsettingsAudioVolume.TabIndex = 2;
            this.nudsettingsAudioVolume.Leave += new System.EventHandler(this.nudsettingsAudioVolume_Leave);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(86, 50);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(55, 17);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "Volume";
            // 
            // chkSettingsLogging
            // 
            this.chkSettingsLogging.AutoSize = true;
            this.chkSettingsLogging.Location = new System.Drawing.Point(6, 21);
            this.chkSettingsLogging.Name = "chkSettingsLogging";
            this.chkSettingsLogging.Size = new System.Drawing.Size(74, 21);
            this.chkSettingsLogging.TabIndex = 2;
            this.chkSettingsLogging.Text = "Enable";
            this.chkSettingsLogging.UseVisualStyleBackColor = true;
            this.chkSettingsLogging.CheckedChanged += new System.EventHandler(this.chkSettingsLogging_CheckedChanged);
            // 
            // txtSettingsLogFilename
            // 
            this.txtSettingsLogFilename.Location = new System.Drawing.Point(6, 48);
            this.txtSettingsLogFilename.Name = "txtSettingsLogFilename";
            this.txtSettingsLogFilename.Size = new System.Drawing.Size(62, 22);
            this.txtSettingsLogFilename.TabIndex = 3;
            this.txtSettingsLogFilename.Text = "log.txt";
            this.txtSettingsLogFilename.Leave += new System.EventHandler(this.txtSettingsLogFilename_Leave);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(74, 50);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(65, 17);
            this.lblFilename.TabIndex = 4;
            this.lblFilename.Text = "Filename";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 567);
            this.Controls.Add(this.btnViewGameSettings);
            this.Controls.Add(this.btnViewSettings);
            this.Controls.Add(this.gbAdvancedSettings);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.gbModFolder);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModMan";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbModFolder.ResumeLayout(false);
            this.gbAdvancedSettings.ResumeLayout(false);
            this.gbAdvancedSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudsettingsAudioVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbModFolder;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox txtAppFolder;
        private System.Windows.Forms.Button btnSettingsFolder;
        private System.Windows.Forms.Button btnModFolder;
        private System.Windows.Forms.Button btnAppFolder;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.GroupBox gbModFolder;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.TextBox txtModFolder;
        private System.Windows.Forms.TextBox txtSettingsFolder;
        private System.Windows.Forms.GroupBox gbAdvancedSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAdancedSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnViewSettings;
        private System.Windows.Forms.Button btnViewGameSettings;
        private System.Windows.Forms.LinkLabel llAppFolder;
        private System.Windows.Forms.LinkLabel llModFolder;
        private System.Windows.Forms.LinkLabel llSettingsFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.NumericUpDown nudsettingsAudioVolume;
        private System.Windows.Forms.CheckBox chkSettingsAudio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtSettingsLogFilename;
        private System.Windows.Forms.CheckBox chkSettingsLogging;
        private System.Windows.Forms.CheckBox chkSettingsDevelopment;
    }
}

