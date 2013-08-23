using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SortOf.Properties;

namespace SortOf
{
    public partial class SetDialog : Form
    {
        Settings Settings = new Settings();

        public SetDialog()
        {
            InitializeComponent();
            SettingsCheck();
        }

        private void SettingsCheck()
        {
            ArchiveBox.Checked = Settings.ArchiveBox;
            DocumentBox.Checked = Settings.DocumentBox;
            EbookBox.Checked = Settings.EbookBox;
            ImageBox.Checked = Settings.ImageBox;
            MusicBox.Checked = Settings.MusicBox;
            OtherBox.Checked = Settings.OtherBox;
            PictureBox.Checked = Settings.PictureBox;
            ProgramBox.Checked = Settings.ProgramBox;
            ShortcutBox.Checked = Settings.ShortcutBox;
            TorrentBox.Checked = Settings.TorrentBox;
            VideoBox.Checked = Settings.VideoBox;
        }

        public void SaveSettings()
        {
            Settings.ArchiveBox = ArchiveBox.Checked;
            Settings.DocumentBox = DocumentBox.Checked;
            Settings.EbookBox = EbookBox.Checked;
            Settings.ImageBox = ImageBox.Checked;
            Settings.MusicBox = MusicBox.Checked;
            Settings.OtherBox = OtherBox.Checked;
            Settings.PictureBox = PictureBox.Checked;
            Settings.ProgramBox = ProgramBox.Checked;
            Settings.ShortcutBox = ShortcutBox.Checked;
            Settings.TorrentBox = TorrentBox.Checked;
            Settings.VideoBox = VideoBox.Checked;
            Settings.Save();
        }

        private void SetTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "GenNode")
            {
                GenPanel.Enabled = true;
                GenPanel.Visible = true;
                CatPanel.Enabled = false;
                CatPanel.Visible = false;
                CatTree.Enabled = false;
                CatTree.Visible = false;
            }
            if (e.Node.Name == "CatNode")
            {
                GenPanel.Enabled = false;
                GenPanel.Visible = false;
                CatPanel.Enabled = true;
                CatPanel.Visible = true;
                CatTree.Enabled = false;
                CatTree.Visible = false;
            }
            if (e.Node.Name == "FileNode")
            {
                GenPanel.Enabled = false;
                GenPanel.Visible = false;
                CatPanel.Enabled = false;
                CatPanel.Visible = false;
                CatTree.Enabled = true;
                CatTree.Visible = true;
            }
        }
    }
}
