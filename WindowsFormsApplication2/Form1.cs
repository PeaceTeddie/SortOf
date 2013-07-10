using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SortOf
{
    public partial class Form1 : Form
    {
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

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.folderBrowserDialog1.ShowDialog();
                string path = folderBrowserDialog1.SelectedPath;
                if (result == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox1.Paste(path.ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void createfold(string foldname)
        {
            try
            {
                string FilePath = this.folderBrowserDialog1.SelectedPath;

                Directory.SetCurrentDirectory(FilePath);

                Directory.CreateDirectory(Name = foldname);

                Directory.SetCurrentDirectory(FilePath + "\\" + foldname);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void sortByExtention(string extType, string CatFolder)
        {
            string FilePath = this.folderBrowserDialog1.SelectedPath;

            string[] zip = Directory.GetFiles(FilePath, "*." +extType,SearchOption.TopDirectoryOnly);
            var zipn = zip.Count();
            for (int i = 0; i <= zipn - 1; i++)
            {
                try
                {
                    Directory.Move(Path.GetFullPath(zip[i]), CatFolder + "\\" + Path.GetFileName(zip[i]));
                }
                catch (Exception)
                {
                    string[] name = zip[i].Split('.');
                    string newName = name[0] + " (" + (i) + ")." +name[1];
                    Directory.Move(Path.GetFullPath(zip[i]), CatFolder + "\\" + Path.GetFileName(newName));
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //ReturnCode
            if (textBox1.Text == "")
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
                createfold("Archives");

                var arcfolder = Directory.GetCurrentDirectory();

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

            }
            
            progressBar1.PerformStep();
            //DocumentExt.
            if (DocumentBox.Checked == true)
            {
                createfold("Documents");

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
            }

            progressBar1.PerformStep();
            //ImageExt.
            if (ImageBox.Checked == true)
            {
                createfold("Images");

                var imgfolder = Directory.GetCurrentDirectory();

                sortByExtention("iso", imgfolder);
                sortByExtention("img", imgfolder);
                sortByExtention("nrg", imgfolder);
            }

            progressBar1.PerformStep();
            //MusicExt.
            if (MusicBox.Checked == true)
            {
                createfold("Music");

                var musfolder = Directory.GetCurrentDirectory();

                sortByExtention("mp3", musfolder);
                sortByExtention("wma", musfolder);
                sortByExtention("wav", musfolder);
                sortByExtention("ogg", musfolder);
                sortByExtention("mid", musfolder);
                sortByExtention("flac", musfolder);
                sortByExtention("acc", musfolder);
                sortByExtention("pls", musfolder);
            }
            
            progressBar1.PerformStep();
            //PictureExt.
            if (PictureBox.Checked == true)
            {
                createfold("Pictures");

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
            }
            
            progressBar1.PerformStep();
            //ProgramExt.
            if (ProgramBox.Checked == true)
            {
                createfold("Programs");

                var exefolder = Directory.GetCurrentDirectory();

                sortByExtention("exe", exefolder);
                sortByExtention("msi", exefolder);
                sortByExtention("bat", exefolder);
                sortByExtention("pif", exefolder);
                sortByExtention("cmd", exefolder);
                sortByExtention("btm", exefolder);
            }

            progressBar1.PerformStep();
            //ShortcutExt.
            if (ShortcutBox.Checked == true)
            {
                createfold("Shortcuts");

                var shofolder = Directory.GetCurrentDirectory();

                sortByExtention("lnk", shofolder);
            }

            progressBar1.PerformStep();
            //VideoExt.
            if (VideoBox.Checked == true)
            {
                createfold("Videos");

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
            }
            
            progressBar1.PerformStep();
            //OtherExt.
            if (OtherBox.Checked == true)
            {
                createfold("Others");

                var othfolder = Directory.GetCurrentDirectory();

                sortByExtention("*", othfolder);
            }

            progressBar1.PerformStep();

            MessageBox.Show("You are Victorious!");
            Application.Restart();
        }
    }
}

