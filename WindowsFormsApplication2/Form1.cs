using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SortOf
{
    public partial class Form1 : Form
    {
        public int SortCount;

        public Form1()
        {
            //if 
            //{
                InitializeComponent();
            //}
            //else
            //{
            //    MessageBox.Show("Another instance of the application is already running.");
            //}
        }        

        public void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.folderBrowserDialog1.ShowDialog();
                string path = folderBrowserDialog1.SelectedPath;
                if (result == DialogResult.OK)
                {
                    PathBox.Clear();
                    PathBox.Paste(path.ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void createfolder(string foldername)
        {
            try
            {
                string FilePath = this.folderBrowserDialog1.SelectedPath;

                Directory.SetCurrentDirectory(FilePath);

                Directory.CreateDirectory(Name = foldername);

                Directory.SetCurrentDirectory(FilePath + "\\" + foldername);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void removefolder(string foldername)
        {
            try
            {
                string FilePath = this.folderBrowserDialog1.SelectedPath;

                Directory.SetCurrentDirectory(FilePath);

                Directory.Delete(foldername);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        public void sortByExtention(string extType, string CatFolder)
        {
            string FilePath = this.folderBrowserDialog1.SelectedPath;

            string[] Files = Directory.GetFiles(FilePath, "*." +extType,SearchOption.TopDirectoryOnly);
            int FileCount = Files.Count();
            if (FileCount != 0)
            {
                SortCount += 1;
                for (int i = 0; i <= FileCount - 1; i++)
                {
                    try
                    {
                        Directory.Move(Path.GetFullPath(Files[i]), CatFolder + "\\" + Path.GetFileName(Files[i]));
                    }
                    catch (Exception)
                    {
                        string[] name = Files[i].Split('.');
                        string newName = name[0] + " (" + (i) + ")." + name[1];
                        Directory.Move(Path.GetFullPath(Files[i]), CatFolder + "\\" + Path.GetFileName(newName));
                    }
                }
            }
        }

        public void SortButton_Click(object sender, EventArgs e)
        {
            //ReturnCode
            if (PathBox.Text == "")
            {
                return;
            }

            //Misc.
            this.Cursor = Cursors.WaitCursor;

            this.progressBar1.BringToFront();

            this.Enabled = false;

            string FilePath = this.folderBrowserDialog1.SelectedPath;

            progressBar1.PerformStep();
            //ArchiveExt.
            if (ArchiveBox.Checked == true)
            {
                createfolder("Archives");

                string arcfolder = Directory.GetCurrentDirectory();

                sortByExtention("zip", arcfolder);
                sortByExtention("rar", arcfolder);
                sortByExtention("7z", arcfolder);
                sortByExtention("ace", arcfolder);
                sortByExtention("cab", arcfolder);
                sortByExtention("tar", arcfolder);
                sortByExtention("jar", arcfolder);
                sortByExtention("pak", arcfolder);
                sortByExtention("pk3", arcfolder);
                sortByExtention("pk4", arcfolder);
                sortByExtention("wad", arcfolder);

                if (SortCount == 0)
                {
                    removefolder(arcfolder);
                }
                else
                    SortCount = 0;

            }
            
            progressBar1.PerformStep();
            //DocumentExt.
            if (DocumentBox.Checked == true)
            {
                createfolder("Documents");

                var docfolder = Directory.GetCurrentDirectory();

                sortByExtention("doc", docfolder);
                sortByExtention("docx", docfolder);
                sortByExtention("pdf", docfolder);
                sortByExtention("xls", docfolder);
                sortByExtention("xlsx", docfolder);
                sortByExtention("txt", docfolder);
                sortByExtention("ppt", docfolder);
                sortByExtention("pptx", docfolder);
                sortByExtention("html", docfolder);
                sortByExtention("htm", docfolder);
                sortByExtention("php", docfolder);
                sortByExtention("xml", docfolder);
                sortByExtention("rtf", docfolder);
                sortByExtention("log", docfolder);
                sortByExtention("css", docfolder);
                
                if (SortCount == 0)
                {
                    removefolder(docfolder);
                }
                else
                    SortCount = 0;
            }

            progressBar1.PerformStep();
            //ImageExt.
            if (ImageBox.Checked == true)
            {
                createfolder("Images");

                var imgfolder = Directory.GetCurrentDirectory();

                sortByExtention("iso", imgfolder);
                sortByExtention("img", imgfolder);
                sortByExtention("nrg", imgfolder);

                if (SortCount == 0)
                {
                    removefolder(imgfolder);
                }
                else
                    SortCount = 0;
            }

            progressBar1.PerformStep();
            //MusicExt.
            if (MusicBox.Checked == true)
            {
                createfolder("Music");

                var musfolder = Directory.GetCurrentDirectory();

                sortByExtention("mp3", musfolder);
                sortByExtention("wma", musfolder);
                sortByExtention("wav", musfolder);
                sortByExtention("ogg", musfolder);
                sortByExtention("mid", musfolder);
                sortByExtention("flac", musfolder);
                sortByExtention("acc", musfolder);
                sortByExtention("pls", musfolder);

                if (SortCount == 0)
                {
                    removefolder(musfolder);
                }
                else
                    SortCount = 0;
            }
            
            progressBar1.PerformStep();
            //PictureExt.
            if (PictureBox.Checked == true)
            {
                createfolder("Pictures");

                var picfolder = Directory.GetCurrentDirectory();

                sortByExtention("jpg", picfolder);
                sortByExtention("jpeg", picfolder);
                sortByExtention("gif", picfolder);
                sortByExtention("png", picfolder);
                sortByExtention("ico", picfolder);
                sortByExtention("bmp", picfolder);
                sortByExtention("psd", picfolder);
                sortByExtention("tif", picfolder);
                sortByExtention("tiff", picfolder);
                sortByExtention("pcx", picfolder);
                sortByExtention("tga", picfolder);
                sortByExtention("dib", picfolder);

                if (SortCount == 0)
                {
                    removefolder(picfolder);
                }
                else
                    SortCount = 0;
            }
            
            progressBar1.PerformStep();
            //ProgramExt.
            if (ProgramBox.Checked == true)
            {
                createfolder("Programs");

                var exefolder = Directory.GetCurrentDirectory();

                sortByExtention("exe", exefolder);
                sortByExtention("msi", exefolder);
                sortByExtention("bat", exefolder);
                sortByExtention("pif", exefolder);
                sortByExtention("cmd", exefolder);
                sortByExtention("btm", exefolder);

                if (SortCount == 0)
                {
                    removefolder(exefolder);
                }
                else
                    SortCount = 0;
            }

            progressBar1.PerformStep();
            //ShortcutExt.
            if (ShortcutBox.Checked == true)
            {
                createfolder("Shortcuts");

                var shofolder = Directory.GetCurrentDirectory();

                sortByExtention("lnk", shofolder);

                if (SortCount == 0)
                {
                    removefolder(shofolder);
                }
                else
                    SortCount = 0;
            }

            progressBar1.PerformStep();
            //VideoExt.
            if (VideoBox.Checked == true)
            {
                createfolder("Videos");

                var vidfolder = Directory.GetCurrentDirectory();

                sortByExtention("rm", vidfolder);
                sortByExtention("mp4", vidfolder);
                sortByExtention("mpg", vidfolder);
                sortByExtention("mpeg", vidfolder);
                sortByExtention("flv", vidfolder);
                sortByExtention("3gp", vidfolder);
                sortByExtention("rmvb", vidfolder);
                sortByExtention("avi", vidfolder);
                sortByExtention("wmv", vidfolder);
                sortByExtention("mkv", vidfolder);
                sortByExtention("vob", vidfolder);
                sortByExtention("mov", vidfolder);

                if (SortCount == 0)
                {
                    removefolder(vidfolder);
                }
                else
                    SortCount = 0;
            }
            
            progressBar1.PerformStep();
            //OtherExt.
            if (OtherBox.Checked == true)
            {
                createfolder("Others");

                var othfolder = Directory.GetCurrentDirectory();

                sortByExtention("*", othfolder);

                if (SortCount == 0)
                {
                    removefolder(othfolder);
                }
                else
                    SortCount = 0;
            }

            progressBar1.PerformStep();

            MessageBox.Show("You are Victorious!");
            Application.Restart();
        }
    }
}

