using ExtManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SortOf.Properties;

namespace SortOf
{
    public partial class Form1 : Form
    {
        #region Declarations
        Archives Archives = new Archives();
        Documents Documents = new Documents();
        Images Images = new Images();
        Music Music = new Music();
        Pictures Pictures = new Pictures();
        Programs Programs = new Programs();
        Settings Settings = new Settings();
        SetDialog SettingsDialog = new SetDialog();
        Shortcuts Shortcuts = new Shortcuts();
        Others Others = new Others();
        Videos Videos = new Videos();
        #endregion

        string CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        void SortOf_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        void SortOf_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string Folder in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Directory.Exists(Folder))
                {
                    CurrentDirectory = Folder;
                    PathBox.Clear();
                    PathBox.Paste(Folder);
                }
            }
        }

        void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = this.Browser.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    CurrentDirectory = Browser.SelectedPath;
                    PathBox.Clear();
                    PathBox.Paste(CurrentDirectory);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        void SortButton_Click(object sender, EventArgs e)
        {
            //ReturnCode
            if (PathBox.Text == "" || !Directory.Exists(PathBox.Text))
            {
                MessageBox.Show("Invalid Directory Path.");
                return;
            }

            //Misc.
            this.Cursor = Cursors.WaitCursor;
            this.ProgBar.BringToFront();
            this.Enabled = false;

            ProgBar.PerformStep();

            #region Sorting Code
            //Archive Sort.
            if (Settings.ArchiveBox == true)
                Archives.Sort(CurrentDirectory);

            ProgBar.PerformStep();

            //Document Sort.
            if (Settings.DocumentBox == true)
                Documents.Sort(CurrentDirectory);

            ProgBar.PerformStep();

            //Image Sort.
            if (Settings.ImageBox == true)
                Images.Sort(CurrentDirectory);

            ProgBar.PerformStep();

            //Music Sort.
            if (Settings.MusicBox == true)
                Music.Sort(CurrentDirectory);

            ProgBar.PerformStep();
            
            //Picture Sort.
            if (Settings.PictureBox == true)
                Pictures.Sort(CurrentDirectory);

            ProgBar.PerformStep();
            
            //Program Sort.
            if (Settings.ProgramBox == true)
                Programs.Sort(CurrentDirectory);

            ProgBar.PerformStep();
            
            //Shortcut Sort.
            if (Settings.ShortcutBox == true)
                Shortcuts.Sort(CurrentDirectory);

            ProgBar.PerformStep();
            
            //Video Sort.
            if (Settings.VideoBox == true)
                Videos.Sort(CurrentDirectory);

            ProgBar.PerformStep();
            
            //Other Sort.
            if (Settings.OtherBox == true)
                Others.Sort(CurrentDirectory);

            ProgBar.PerformStep();

            #endregion

            MessageBox.Show("You are Victorious!");
            Application.Restart();
        }
        void UnsortButton_Click(object sender, EventArgs e)
        {
            //ReturnCode
            if (PathBox.Text == "" || !Directory.Exists(PathBox.Text))
            {
                MessageBox.Show("Invalid Directory Path.");
                return;
            }

            //Misc.
            this.Cursor = Cursors.WaitCursor;
            this.ProgBar.BringToFront();
            this.Enabled = false;

            ProgBar.PerformStep();

            #region Unsorting Code
            //Archive Sort.
            if (Settings.ArchiveBox == true)
                Archives.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Document Unsort.
            if (Settings.DocumentBox == true)
                Documents.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Image Unsort.
            if (Settings.ImageBox == true)
                Images.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Music Unsort.
            if (Settings.MusicBox == true)
                Music.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Picture Unsort.
            if (Settings.PictureBox == true)
                Pictures.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Program Unsort.
            if (Settings.ProgramBox == true)
                Programs.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Shortcut Unsort.
            if (Settings.ShortcutBox == true)
                Shortcuts.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Video Unsort.
            if (Settings.VideoBox == true)
                Videos.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            //Other Unsort.
            if (Settings.OtherBox == true)
                Others.Unsort(CurrentDirectory);

            ProgBar.PerformStep();

            #endregion

            MessageBox.Show("You are Victorious!");
            Application.Restart();
        }

        void SetButton_Click(object sender, EventArgs e)
        {
            DialogResult SetResult = SettingsDialog.ShowDialog();
            if (SetResult == DialogResult.OK)            
                SettingsDialog.SaveSettings();
            Settings.Reload();            
        }
    }
}

