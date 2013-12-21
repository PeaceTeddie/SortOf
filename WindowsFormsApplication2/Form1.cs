using ExtManager;
using SortOf.Properties;
using SortingEngine;
using System;
using System.IO;
using System.Windows.Forms;

namespace SortOf
{
    public partial class Form1 : Form
    {
        #region Declarations

        private Archives Archives = new Archives();
        private Documents Documents = new Documents();
        private Ebooks Ebooks = new Ebooks();
        private Images Images = new Images();
        private Music Music = new Music();
        private Pictures Pictures = new Pictures();
        private Programs Programs = new Programs();
        private SetDialog SetDialog = new SetDialog();
        private Settings Settings = new Settings();
        private Shortcuts Shortcuts = new Shortcuts();
        private Sorter Sorter = new Sorter();
        private Torrents Torrents = new Torrents();
        private Others Others = new Others();
        private UnSorter UnSorter = new UnSorter();
        private Videos Videos = new Videos();

        #endregion Declarations

        private string CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
            FillContextMenu();

            SetDialog.Settings = Settings;
        }

        private void SaveRecent()
        {
            try
            {
                if (CurrentDirectory == Settings.RecentOne)
                    return;
                else if (CurrentDirectory == Settings.RecentTwo)
                {
                    Settings.RecentTwo = Settings.RecentOne;
                    Settings.RecentOne = CurrentDirectory;
                }
                else
                {
                    Settings.RecentThree = Settings.RecentTwo;
                    Settings.RecentTwo = Settings.RecentOne;
                    Settings.RecentOne = CurrentDirectory;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void FillContextMenu()
        {
            string[] Recent =
            {
                Settings.RecentOne,
                Settings.RecentTwo,
                Settings.RecentThree
            };

            try
            {
                foreach (string s in Recent)
                {
                    if (s != null && s != "")
                        ContextMenuStrip.Items.Add(s);
                }
            }
            catch (Exception) { }
        }

        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CurrentDirectory = e.ClickedItem.Text;
            PathBox.Clear();
            PathBox.Paste(e.ClickedItem.Text);
        }

        private void SortOf_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void SortOf_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (Directory.Exists((string)e.Data.GetData(DataFormats.FileDrop)))
                {
                    CurrentDirectory = (string)e.Data.GetData(DataFormats.FileDrop);
                    PathBox.Clear();
                    PathBox.Paste((string)e.Data.GetData(DataFormats.FileDrop));
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = this.Browser.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    CurrentDirectory = Browser.SelectedPath;
                    PathBox.Clear();
                    PathBox.Paste(Browser.SelectedPath);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            DialogResult SetResult = SetDialog.ShowDialog();
            if (SetResult == DialogResult.OK)
                Settings = SetDialog.SaveSettings();
            Settings.Reload();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            //ReturnCode
            if (Directory.Exists(PathBox.Text))
                Sorter.CurrentDirectory = CurrentDirectory + "\\";
            else if (!Directory.Exists(PathBox.Text))
            {
                MessageBox.Show("Invalid Directory Path.");
                return;
            }

            //Misc.
            this.Cursor = Cursors.WaitCursor;
            this.ProgBar.BringToFront();
            this.Enabled = false;

            SaveRecent();
            ProgBar.PerformStep();

            #region Sorting Code

            //Archive Sort.
            if (Settings.ArchiveBox == true)
                Archives.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Archives.Extensions);

            ProgBar.PerformStep();

            //Document Sort.
            if (Settings.DocumentBox == true)
                Documents.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Documents.Extensions);

            ProgBar.PerformStep();

            //Ebook Sort.
            if (Settings.EbookBox == true)
                Ebooks.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Ebooks.Extensions);

            //Image Sort.
            if (Settings.ImageBox == true)
                Images.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Images.Extensions);

            ProgBar.PerformStep();

            //Music Sort.
            if (Settings.MusicBox == true)
                Music.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Music.Extensions);

            ProgBar.PerformStep();

            //Picture Sort.
            if (Settings.PictureBox == true)
                Pictures.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Pictures.Extensions);

            ProgBar.PerformStep();

            //Program Sort.
            if (Settings.ProgramBox == true)
                Programs.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Programs.Extensions);

            ProgBar.PerformStep();

            //Shortcut Sort.
            if (Settings.ShortcutBox == true)
                Shortcuts.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Shortcuts.Extensions);

            ProgBar.PerformStep();

            //Torrent Sort.
            if (Settings.TorrentBox == true)
                Torrents.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Torrents.Extensions);

            //Video Sort.
            if (Settings.VideoBox == true)
                Videos.Sort(Sorter);
            else if (Settings.ArchiveBox == false)
                Others.ExcludeExts(Videos.Extensions);

            ProgBar.PerformStep();

            //Other Sort.
            if (Settings.OtherBox == true)
                Others.Sort(Sorter);

            ProgBar.PerformStep();

            #endregion Sorting Code

            MessageBox.Show("You are Victorious!");
            Settings.Save();
            Application.Restart();
        }

        private void UnsortButton_Click(object sender, EventArgs e)
        {
            //ReturnCode
            if (Directory.Exists(CurrentDirectory))
                UnSorter.CurrentDirectory = CurrentDirectory + "\\";
            else if (!Directory.Exists(CurrentDirectory))
            {
                MessageBox.Show("Invalid Directory Path.");
                return;
            }

            //Misc.
            this.Cursor = Cursors.WaitCursor;
            this.ProgBar.BringToFront();
            this.Enabled = false;

            SaveRecent();
            ProgBar.PerformStep();

            #region Unsorting Code

            //Archive Unsort.
            if (Settings.ArchiveBox == true)
                Archives.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Document Unsort.
            if (Settings.DocumentBox == true)
                Documents.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Ebook Unsort.
            if (Settings.EbookBox == true)
                Ebooks.Unsort(UnSorter);

            //Image Unsort.
            if (Settings.ImageBox == true)
                Images.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Music Unsort.
            if (Settings.MusicBox == true)
                Music.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Picture Unsort.
            if (Settings.PictureBox == true)
                Pictures.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Program Unsort.
            if (Settings.ProgramBox == true)
                Programs.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Shortcut Unsort.
            if (Settings.ShortcutBox == true)
                Shortcuts.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Torrent Unsort.
            if (Settings.TorrentBox == true)
                Torrents.Unsort(UnSorter);

            //Video Unsort.
            if (Settings.VideoBox == true)
                Videos.Unsort(UnSorter);

            ProgBar.PerformStep();

            //Other Unsort.
            if (Settings.OtherBox == true)
                Others.Unsort(UnSorter);

            ProgBar.PerformStep();

            #endregion Unsorting Code

            MessageBox.Show("You are Unvictorious!");
            Settings.Save();
            Application.Restart();
        }
    }
}