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
        string ActiveDirectory { get; set; } //Application generated folder
        public string CurrentDirectory { get; set; } //Choosen directory

        List<FileItem> FileList = new List<FileItem>();

        void MoveFiles(List<FileItem> filelist, string ActDir)
        {
            foreach (FileItem file in filelist)
            {
                try
                {
                    //Move file if no file with same name exists.
                    if (!File.Exists(ActDir + file.NameWithExtension))
                        File.Move(file.FullPath, ActDir + file.NameWithExtension);

                    else
                    {
                        //Loops an int++ until a valid name has been generated.
                        for (int i = 0; i <= Directory.GetFiles(ActDir).Count(); i++)
                        {
                            if (!File.Exists(ActDir + file.Filename + $"({i})" + file.Extension))
                            {
                                File.Move(file.FullPath, ActDir + file.Filename + $"({i})" + file.Extension);
                                break;
                            }

                        }
                    }
                }
                catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }

        void DeleteFolder()
        {
            if (Directory.Exists(ActiveDirectory) &&
                Directory.GetFiles(ActiveDirectory).Count() == 0 &&
                Directory.GetDirectories(ActiveDirectory).Count() == 0)
                Directory.Delete(ActiveDirectory);
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
                {
                    #region Failsafe since extensions like .doc and .docx create duplicate entries
                    bool Exists = false;

                    foreach (FileItem F in FileList)
                        if (S == F.FullPath) { Exists = true; break; }

                    if (Exists) continue;
                    #endregion

                    FileList.Add(new FileItem(S));
                }

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
        string ActiveDirectory { get; set; }
        public string CurrentDirectory { get; set; }

        List<string> FileList = new List<string>();

        void MoveFiles(List<string> filelist)
        {
            foreach (string file in filelist)
            {
                try
                {
                    File.Move(file, CurrentDirectory + Path.GetFileName(file));
                }
                catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }

        void DeleteFolder()
        {
            if (Directory.GetFiles(ActiveDirectory).Count() == 0 &&
                Directory.GetDirectories(ActiveDirectory).Count() == 0)
                Directory.Delete(ActiveDirectory);
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

            FileList.Clear();
        }
    }
}