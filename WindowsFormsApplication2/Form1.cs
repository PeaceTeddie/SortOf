using ExtManager;
using System;
using System.IO;
using System.Windows.Forms;

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
            this.progressBar1.BringToFront();
            this.Enabled = false;

            progressBar1.PerformStep();

            #region Sorting Code
            //Archive Sort.
            if (ArchiveBox.Checked == true)
                Archives.Sort(CurrentDirectory);

            progressBar1.PerformStep();

            //Document Sort.
            if (DocumentBox.Checked == true)
                Documents.Sort(CurrentDirectory);

            progressBar1.PerformStep();

            //Image Sort.
            if (ImageBox.Checked == true)
                Images.Sort(CurrentDirectory);

            progressBar1.PerformStep();

            //Music Sort.
            if (MusicBox.Checked == true)
                Music.Sort(CurrentDirectory);

            progressBar1.PerformStep();
            
            //Picture Sort.
            if (PictureBox.Checked == true)
                Pictures.Sort(CurrentDirectory);

            progressBar1.PerformStep();
            
            //Program Sort.
            if (ProgramBox.Checked == true)
                Programs.Sort(CurrentDirectory);

            progressBar1.PerformStep();
            
            //Shortcut Sort.
            if (ShortcutBox.Checked == true)
                Shortcuts.Sort(CurrentDirectory);

            progressBar1.PerformStep();
            
            //Video Sort.
            if (VideoBox.Checked == true)
                Videos.Sort(CurrentDirectory);

            progressBar1.PerformStep();
            
            //Other Sort.
            if (OtherBox.Checked == true)
                Others.Sort(CurrentDirectory);

            progressBar1.PerformStep();

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
            this.progressBar1.BringToFront();
            this.Enabled = false;

            progressBar1.PerformStep();

            #region Unsorting Code
            //Archive Sort.
            if (ArchiveBox.Checked == true)
                Archives.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Document Unsort.
            if (DocumentBox.Checked == true)
                Documents.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Image Unsort.
            if (ImageBox.Checked == true)
                Images.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Music Unsort.
            if (MusicBox.Checked == true)
                Music.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Picture Unsort.
            if (PictureBox.Checked == true)
                Pictures.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Program Unsort.
            if (ProgramBox.Checked == true)
                Programs.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Shortcut Unsort.
            if (ShortcutBox.Checked == true)
                Shortcuts.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Video Unsort.
            if (VideoBox.Checked == true)
                Videos.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            //Other Unsort.
            if (OtherBox.Checked == true)
                Others.Unsort(CurrentDirectory);

            progressBar1.PerformStep();

            #endregion

            MessageBox.Show("You are Victorious!");
            Application.Restart();
        }
    }
}

