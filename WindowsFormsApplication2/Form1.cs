using MiscLib;
using SortingEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace SortOf
{
    public partial class MainForm : Form
    {
        #region Declarations
        SetDialog SetDialog;
        Sorter Sorter = new Sorter();
        Manager Manager = new Manager();
        Settings Settings = new Settings();
        UnSorter UnSorter = new UnSorter();

        public static CatList CatList = new CatList();

        #endregion Declarations

        string CurrentDirectory;

        public MainForm()
        {
            CatList = Manager.InitializeCatList();

            InitializeComponent();
            FillContextMenu();
        }

        void UpdateRecent()
        {
            try
            {
                if (CurrentDirectory == Settings.RecentOne)
                {

                }

                else if (CurrentDirectory == Settings.RecentTwo)
                {
                    Settings.RecentTwo = Settings.RecentOne;
                    Settings.RecentOne = CurrentDirectory.Trim('\\');
                }

                else
                {
                    Settings.RecentThree = Settings.RecentTwo;
                    Settings.RecentTwo = Settings.RecentOne;
                    Settings.RecentOne = CurrentDirectory.Trim('\\');
                }

                Settings.Save();
                Settings.Reload();
                FillContextMenu();
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        void FillContextMenu()
        {
            string[] Recent =
            {
                Settings.RecentOne,
                Settings.RecentTwo,
                Settings.RecentThree
            };

            try
            {
                ContextMenuStrip.Items.Clear();

                foreach (string s in Recent)
                {
                    if (s != null && s != "")
                        ContextMenuStrip.Items.Add(s);
                }
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        void ContextClick(object sender, ToolStripItemClickedEventArgs e)
        {
            PathBox.Clear();
            PathBox.Paste(e.ClickedItem.Text);
            CurrentDirectory = e.ClickedItem.Text;
        }

        void OnDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        void OnDragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] FileDrop = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (Directory.Exists(FileDrop[0]))
                {
                    PathBox.Clear();
                    PathBox.Paste(FileDrop[0]);
                    CurrentDirectory = FileDrop[0];
                }

            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        void BrowseClick(object sender, EventArgs e)
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
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        void SettingsClick(object sender, EventArgs e)
        {
            SetDialog = new SetDialog();
            DialogResult SetResult = SetDialog.ShowDialog();
        }

        void SortClick(object sender, EventArgs e)
        {
            //Path Check & Return Code
            if (Directory.Exists(PathBox.Text))
            {
                CurrentDirectory = PathBox.Text + "\\";
                Sorter.CurrentDirectory = CurrentDirectory;
            }

            else if (!Directory.Exists(PathBox.Text))
            {
                MessageBox.Show("Invalid Directory Path.");
                return;
            }

            //Misc.
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            this.ProgBar.Step = 100 / CatList.Count;

            UpdateRecent();
            ProgBar.Show();

            #region Sorting Code

            foreach (Category Cat in CatList)
            {
                try
                {
                    if (Cat.ShouldSort)
                        Sorter.Sort(Cat);

                    ProgBar.PerformStep();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    return;
                }
            }

            #endregion Sorting Code

            MessageBox.Show("You are Victorious!");
            ProgBar.Value = 0;
            Settings.Save();
            ProgBar.Hide();

            this.Cursor = Cursors.Default;
            this.Enabled = true;
        }

        void UnsortClick(object sender, EventArgs e)
        {
            //ReturnCode
            if (Directory.Exists(PathBox.Text))
            {
                CurrentDirectory = PathBox.Text + "\\";
                UnSorter.CurrentDirectory = CurrentDirectory;
            }
            else if (!Directory.Exists(CurrentDirectory))
            {
                MessageBox.Show("Invalid Directory Path.");
                return;
            }

            //Misc.
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            this.ProgBar.Step = 100 / CatList.Count;

            UpdateRecent();
            ProgBar.Show();

            #region Unsorting Code

            foreach (Category Cat in CatList)
            {
                if (Cat.ShouldSort)
                    UnSorter.UnSort(Cat);

                ProgBar.PerformStep();
            }

            #endregion Unsorting Code

            MessageBox.Show("You are Unvictorious!");
            ProgBar.Value = 0;
            Settings.Save();
            ProgBar.Hide();

            this.Cursor = Cursors.Default;
            this.Enabled = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Manager.SaveCurrentCatList(CatList);
            base.OnClosing(e);
        }
    }
}