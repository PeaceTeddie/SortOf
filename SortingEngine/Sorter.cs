using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingEngine
{
    public class Sorter
    {
        bool SortingDone;
        public string CurrentDirectory { get; set; }

        public void Check(string ExtFolder)
        {
            int FileCount = Directory.GetFiles(CurrentDirectory + "\\" + ExtFolder).Count();

            if (!SortingDone && FileCount == 0)
                RemoveFolder(CurrentDirectory + "\\" + ExtFolder);            
        }

        public void CreateFolder(string Folder)
        {
            try
            {
                Directory.CreateDirectory(CurrentDirectory + "\\" + Folder);
            }
            catch (Exception) { }
        }

        private void RemoveFolder(string Folder)
        {
            try
            {
                Directory.Delete(CurrentDirectory + "\\" + Folder);
            }
            catch (Exception) { }
        }

        public void ByExtension(string Extension, string ExtFolder)
        {
            string[] Files = Directory.GetFiles(CurrentDirectory, "*." + Extension, SearchOption.TopDirectoryOnly);

            int FileCount = Files.Count();
            if (FileCount != 0)
            {
                foreach (string File in Files)
                {
                    try
                    {
                        Directory.Move(Path.GetFullPath(File), CurrentDirectory + "\\" + ExtFolder + "\\" + Path.GetFileName(File));
                    }
                    catch (Exception)
                    {
                        string[] Name = File.Split('.');
                        string NewName = Name[0] + " (" + 1 + ")." + Name[1];
                        Directory.Move(Path.GetFullPath(File), CurrentDirectory + "\\" + ExtFolder + "\\" + Path.GetFileName(NewName));
                    }
                }
                SortingDone = true;
            }
            else
                SortingDone = false;
        }
    }
}

