using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ModMan.Properties;

namespace ModMan
{
    public partial class frmMain : Form
    {
        public static bool bShowAdvancedSettings = false;
        public static int iShowAdvancedSettings = 0;
        public static string sAppFolder = string.Empty;
        public static string sSettingsFolder = string.Empty;
        public static string sModFolder = string.Empty;
        public static string sModFolderDir = string.Empty;
        public static Point pGBAdvancedSettings;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pGBAdvancedSettings = gbModFolder.Location;

            //TEMP - Remove when advanced settings are added - next three rows
            //HideAdvancedSettings();
            //showAdancedSettingsToolStripMenuItem.Visible = false;
            //toolStripSeparator1.Visible = false;

            BuildToolTips();
            GetSettings();
            GetAppSettings();
            GetGameSettings();
            ListModFolders();

            if (bShowAdvancedSettings)
            {
                ShowAdvancedSettings();
            }
            else
            {
                HideAdvancedSettings();
            }
        }

        private void BuildToolTips()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.btnAppFolder, "This is the folder where FarmingSimulator2019.exe is located.");
            toolTip.SetToolTip(this.txtAppFolder, "This is the folder where FarmingSimulator2019.exe is located.");
            toolTip.SetToolTip(this.btnSettingsFolder, "This is the folder where gameSettings.xml is located.");
            toolTip.SetToolTip(this.txtSettingsFolder, "This is the folder where gameSettings.xml is located.");
            toolTip.SetToolTip(this.btnModFolder, "This is the root folder where all your other mod folders are located.");
            toolTip.SetToolTip(this.txtModFolder, "This is the root folder where all your other mod folders are located.");
        }

        private void GetSettings()
        {
            //app.config
            bShowAdvancedSettings = Settings.Default.ShowAdvancedSettings;
            iShowAdvancedSettings = Convert.ToInt32(bShowAdvancedSettings);
            sAppFolder = Settings.Default.AppFolder;
            sSettingsFolder = Settings.Default.SettingsFolder;
            sModFolder = Settings.Default.ModFolder;

            //Display Items on Screen
            showAdancedSettingsToolStripMenuItem.CheckState = (CheckState)iShowAdvancedSettings;
            txtAppFolder.Text = sAppFolder;
            txtSettingsFolder.Text = sSettingsFolder;
            txtModFolder.Text = sModFolder;
        }

        private void GetAppSettings()
        {
            try
            {
                string val;
                string gsFile = sSettingsFolder + "\\gameSettings.xml";
                XDocument xmlDoc = XDocument.Load(gsFile);

                if (sSettingsFolder != string.Empty)
                {
                    if (sModFolder != string.Empty)
                    {
                        var sFolder = xmlDoc.Descendants("modsDirectoryOverride").SingleOrDefault();
                        var attr = sFolder.Attribute("directory");
                        sModFolderDir = attr.Value.Substring(attr.Value.LastIndexOf("\\") + 1);
                    }
                    else
                    {
                        if (xmlDoc.Descendants("modsDirectoryOverride").Any())
                        {
                            DeleteElement("modsDirectoryOverride", gsFile);
                            addToXml("modsDirectoryOverride", gsFile);
                            val = sModFolder.Substring(sModFolder.LastIndexOf("\\") + 1);
                            lbModFolder.SelectedItem = val;
                        }
                        else
                        {
                            DeleteElement("modsDirectoryOverride", gsFile);
                            addToXml("modsDirectoryOverride", gsFile);
                        }
                    }
                }
            }
            catch (IOException ex)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetGameSettings()
        {
            try
            {
                string gsFile = sSettingsFolder + "\\game.xml";
                XDocument xmlDoc = XDocument.Load(gsFile);

                if (sSettingsFolder != string.Empty)
                {
                    var vAudio = xmlDoc.Descendants("audio").SingleOrDefault();
                    chkSettingsAudio.Checked = Convert.ToBoolean(vAudio.Attribute("enable").Value.ToString());
                    nudsettingsAudioVolume.Text = vAudio.Attribute("volume").Value.ToString();

                    var vFile = xmlDoc.Descendants("file").SingleOrDefault();
                    chkSettingsLogging.Checked = Convert.ToBoolean(vFile.Attribute("enable").Value.ToString());
                    txtSettingsLogFilename.Text = vFile.Attribute("filename").Value.ToString();

                    var vControls = xmlDoc.Descendants("development").SingleOrDefault();
                    chkSettingsDevelopment.Checked = Convert.ToBoolean(vControls.Element("controls").Value.ToString());
                }
            }
            catch (IOException ex)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetAdvancedSettings()
        {
            try
            {
                if (sSettingsFolder != string.Empty)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(sSettingsFolder + "\\game.xml");

                    if (xml.InnerXml.Contains("audio"))
                    {
                        XmlNode node = xml.SelectSingleNode("/game/audio");
                        node.Attributes["enable"].Value = chkSettingsAudio.Checked.ToString().ToLower();
                        node.Attributes["volume"].Value = nudsettingsAudioVolume.Value.ToString();
                    }

                    if (xml.InnerXml.Contains("file"))
                    {
                        XmlNode node = xml.SelectSingleNode("/game/logging/file");
                        node.Attributes["enable"].Value = chkSettingsLogging.Checked.ToString().ToLower();
                        node.Attributes["filename"].Value = txtSettingsLogFilename.Text.ToString().ToLower();
                    }

                    if (xml.InnerXml.Contains("development"))
                    {
                        XmlNode node = xml.SelectSingleNode("/game/development/controls");
                        node.InnerText = chkSettingsDevelopment.Checked.ToString().ToLower();
                    }

                    xml.Save(sSettingsFolder + "\\game.xml");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteElement(string sElement, string sFile)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(sFile);
                XmlNodeList nodeList = xmlDoc.SelectNodes("//" + sElement);
                for (int i = 0; i < nodeList.Count; i++)
                {
                    nodeList[i].ParentNode.RemoveChild(nodeList[i]);
                }
                xmlDoc.Save(sFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addToXml(string sNode, string sFile)
        {
            try
            {
                XDocument xmlDoc;

                switch (sNode)
                {
                    case "modsDirectoryOverride":
                        xmlDoc = XDocument.Load(sFile);
                        xmlDoc.Element("gameSettings").Add(new XElement(sNode,
                                                        new XAttribute("active", "true"),
                                                        new XAttribute("directory", sModFolder)));
                        xmlDoc.Save(sFile);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListModFolders()
        {
            lbModFolder.Items.Clear();

            try
            {
                if (sModFolder != string.Empty)
                {
                    DirectoryInfo dinfo = new DirectoryInfo(sModFolder);
                    foreach (DirectoryInfo dir in dinfo.GetDirectories())
                    {
                        lbModFolder.Items.Add(dir.Name);
                    }
                    lbModFolder.SelectedItem = sModFolderDir;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbModFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (sSettingsFolder != string.Empty)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(sSettingsFolder + "\\gameSettings.xml");

                    if (xml.InnerXml.Contains("modsDirectoryOverride"))
                    {
                        XmlNode node = xml.SelectSingleNode("/gameSettings/modsDirectoryOverride");
                        node.Attributes["directory"].Value = sModFolder + "\\" + lbModFolder.SelectedItem.ToString();
                        node.Attributes["active"].Value = "true";
                        xml.Save(sSettingsFolder + "\\gameSettings.xml");
                    }
                    else
                    {
                        XmlElement elem = xml.CreateElement("modsDirectoryOverride");
                        XmlAttribute attr1 = xml.CreateAttribute("active");
                        XmlAttribute attr2 = xml.CreateAttribute("directory");
                        xml.DocumentElement.AppendChild(elem);
                        xml.DocumentElement.LastChild.AppendChild(attr1);
                        xml.DocumentElement.LastChild.AppendChild(attr2);
                        xml.Save(sSettingsFolder + "\\gameSettings.xml");

                        xml.Load(sSettingsFolder + "\\gameSettings.xml");
                        XmlNode node = xml.SelectSingleNode("/gameSettings/modsDirectoryOverride");
                        node.Attributes["directory"].Value = sModFolder + "\\" + lbModFolder.SelectedItem.ToString();
                        node.Attributes["active"].Value = "true";
                        xml.Save(sSettingsFolder + "\\gameSettings.xml");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAdvancedSettings()
        {
            gbAdvancedSettings.Visible = true;
            gbModFolder.Location = pGBAdvancedSettings;
            this.Height = 500;
            this.MinimumSize = new Size(598, 500);
            this.MaximumSize = new Size(598, 500);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Normal;
        }

        private void HideAdvancedSettings()
        {
            gbAdvancedSettings.Visible = false;
            gbModFolder.Location = gbAdvancedSettings.Location;
            this.Height = 412;
            this.MinimumSize = new Size(598, 412);
            this.MaximumSize = new Size(598, 412);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnAppFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.AppFolder = folderBrowserDialog.SelectedPath;
                Settings.Default.Save();
            }
            GetSettings();
        }

        private void btnSettingsFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.SettingsFolder = folderBrowserDialog.SelectedPath;
                Settings.Default.Save();
            }
            GetSettings();
        }

        private void btnModFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.ModFolder = folderBrowserDialog.SelectedPath;
                Settings.Default.Save();
            }
            GetSettings();
            ListModFolders();
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Settings.Default.SettingsFolder + "\\log.txt");
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Cannot find log.txt. Check to make sure the settings folder is set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewSettings_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Settings.Default.SettingsFolder + "\\game.xml");
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Cannot find game.xml. Check to make sure the settings folder is set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewGameSettings_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Settings.Default.SettingsFolder + "\\gameSettings.xml");
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Cannot find gameSettings.xml. Check to make sure the settings folder is set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Settings.Default.AppFolder + "\\FarmingSimulator2019.exe");
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Cannot find FarmingSimulator2019.exe. Check to make sure the application folder is set correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout AboutForm = new frmAbout();
            AboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAdancedSettingsToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (showAdancedSettingsToolStripMenuItem.Checked)
            {
                bShowAdvancedSettings = true;
                Settings.Default.ShowAdvancedSettings = true;
                Settings.Default.Save();
            }
            else
            {
                bShowAdvancedSettings = false;
                Settings.Default.ShowAdvancedSettings = false;
                Settings.Default.Save();
            }

            if (bShowAdvancedSettings)
            {
                ShowAdvancedSettings();
            }
            else
            {
                HideAdvancedSettings();
            }
        }

        private void llAppFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer", Settings.Default.AppFolder);
        }

        private void llSettingsFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer", Settings.Default.SettingsFolder);
        }

        private void llModFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer", Settings.Default.ModFolder);
        }

        private void chkSettingsLogging_CheckedChanged(object sender, EventArgs e)
        {
            SetAdvancedSettings();
        }

        private void txtSettingsLogFilename_Leave(object sender, EventArgs e)
        {
            SetAdvancedSettings();
        }

        private void chkSettingsAudio_CheckedChanged(object sender, EventArgs e)
        {
            SetAdvancedSettings();
        }

        private void nudsettingsAudioVolume_Leave(object sender, EventArgs e)
        {
            SetAdvancedSettings();
        }

        private void chkSettingsDevelopment_CheckedChanged(object sender, EventArgs e)
        {
            SetAdvancedSettings();
        }
    }
}
