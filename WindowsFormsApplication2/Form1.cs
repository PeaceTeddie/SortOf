using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using ExtManager;

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

        public void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = this.folderBrowserDialog1.ShowDialog();
                CurrentDirectory = folderBrowserDialog1.SelectedPath;
                if (Result == DialogResult.OK)
                {
                    PathBox.Clear();
                    PathBox.Paste(CurrentDirectory);                    
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void SortButton_Click(object sender, EventArgs e)
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
            //ArchiveExt.
            if (ArchiveBox.Checked == true)
            {
                Archives.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //DocumentExt.
            if (DocumentBox.Checked == true)
            {
                Documents.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //ImageExt.
            if (ImageBox.Checked == true)
            {
                Images.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //MusicExt.
            if (MusicBox.Checked == true)
            {
                Music.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //PictureExt.
            if (PictureBox.Checked == true)
            {
                Pictures.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //ProgramExt.
            if (ProgramBox.Checked == true)
            {
                Programs.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //ShortcutExt.
            if (ShortcutBox.Checked == true)
            {
                Shortcuts.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //VideoExt.
            if (VideoBox.Checked == true)
            {
                Videos.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();
            //OtherExt.
            if (OtherBox.Checked == true)
            {
                Others.Sort(CurrentDirectory);
            }

            progressBar1.PerformStep();

            MessageBox.Show("You are Victorious!");
            Application.Restart();
        }
    }
}

