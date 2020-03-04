using MiscLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SortingEngine
{
    public class Sorter
    {
        public List<FileItem> FileList = new List<FileItem>();

        public string CurrentDirectory { get; set; } //Choosen directory
        private string ActiveDirectory { get; set; } //Application generated folder

        private void MoveFiles(List<FileItem> filelist, string ActDir)
        {
            foreach (FileItem file in filelist)
            {
                try
                {//Move file if no file with same name exists.
                    if (!File.Exists(ActDir + file.NameWithExtension))
                        File.Move(file.FullPath, ActDir + file.NameWithExtension);
                    else
                    {//Creates a loop that increases int i to a maximum of file.count in active directory & adds i to filename to avoid duplicate exception. Ends with return to avoid multiple executions.
                        for (int i = 0; i <= Directory.GetFiles(ActDir).Count(); i++)
                        {
                            if (!File.Exists(ActDir + file.Filename + $"({i})" + file.Extension))
                            {
                                File.Move(file.FullPath, ActDir + file.Filename + $"({i})" + file.Extension);
                                return;
                            }

                        }
                    }
                }
                catch (Exception E)
                {//incase of unexpected exception.
                    MessageBox.Show(E.Message);
                    return; 
                }
            }
        }

        private void DeleteFolder()
        {
            if (Directory.Exists(ActiveDirectory))
                if (Directory.GetFiles(ActiveDirectory).Count() == 0)
                    Directory.Delete(ActiveDirectory);
                else return;
            else return;
        }

        public void Sort(Category Cat)
        {
            ActiveDirectory = CurrentDirectory + Cat.Folder;

            List<string> TempList = new List<string>();

            foreach (Extension E in Cat.Extensions)
                TempList.AddRange(Directory.GetFiles(CurrentDirectory, "*." + E.Name, SearchOption.TopDirectoryOnly));

            if (TempList.Count() > 0)
            {
                foreach (string S in TempList)
                    FileList.Add(new FileItem(S));

                if (!Directory.Exists(ActiveDirectory))
                    Directory.CreateDirectory(ActiveDirectory); 

                MoveFiles(FileList, ActiveDirectory);
            }
            else DeleteFolder();

            TempList.Clear();
            FileList.Clear();
        }
    }

    public class UnSorter
    {
        public List<string> FileList = new List<string>();

        public string CurrentDirectory { get; set; }
        private string ActiveDirectory { get; set; }

        private void MoveFiles(List<string> filelist)
        {
            foreach (string file in filelist)
            {
                try
                {
                    File.Move(file, CurrentDirectory + Path.GetFileName(file));
                }
                catch (Exception) { return; }
            }
        }

        private void DeleteFolder()
        {
            if (Directory.Exists(ActiveDirectory))
                if (Directory.GetFiles(ActiveDirectory).Count() == 0)
                    Directory.Delete(ActiveDirectory);
                else return;
            else return;
        }

        public void UnSort(Category Cat)
        {
            ActiveDirectory = CurrentDirectory + Cat.Folder;

            if (Directory.Exists(ActiveDirectory))
            {
                FileList.AddRange(Directory.GetFiles(ActiveDirectory, "*", SearchOption.TopDirectoryOnly));

                if (FileList.Count > 0)
                    MoveFiles(FileList);

                DeleteFolder();
            }
            else return;

            FileList.Clear();
        }
    }
}