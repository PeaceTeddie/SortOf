using SortOf.Properties;
using System;
using System.Windows.Forms;

namespace SortOf
{
    public partial class SetDialog : Form
    {
        Settings Settings;

        internal SetDialog(Settings settings)
        {
            InitializeComponent();
            Settings = settings;
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

        internal Settings SaveSettings()
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
            Settings.Reload();
            return Settings;
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult DefaultAsk = MessageBox.Show(SetDialog.ActiveForm, "Do you really want to reset the settings to default?", "Reset to default settings?", MessageBoxButtons.YesNo);
            if (DefaultAsk == DialogResult.Yes)
            {
                Settings.RecentOne = "";
                Settings.RecentTwo = "";
                Settings.RecentThree = "";
                Settings.Reset();
                Settings.Save();
            }
            else 
                return;
        }
    }
}