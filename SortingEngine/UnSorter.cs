using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingEngine
{
    public class UnSorter
    {
        public string CurrentDirectory { get; set; }

        public void Check(string ExtFolder)
        {
            if (Directory.Exists(CurrentDirectory + "\\" + ExtFolder))
            {
                int FileCount = Directory.GetFiles(CurrentDirectory + "\\" + ExtFolder).Count();

                if (FileCount == 0)
                    RemoveFolder(CurrentDirectory + "\\" + ExtFolder);
            }
            else return;
        }

        private void RemoveFolder(string Folder)
        {
            try
            {
                Directory.Delete(Folder);
            }
            catch (Exception) { }
        }

        public void ByFolder(string ExtFolder) 
        {
            if (Directory.Exists(CurrentDirectory + "\\" + ExtFolder))
            {
                string[] Files = Directory.GetFiles(CurrentDirectory + "\\" + ExtFolder, "*", SearchOption.TopDirectoryOnly);

                int FileCount = Files.Count();
                if (FileCount != 0)
                {
                    foreach (string File in Files)
                    {
                        int i = 0;

                        try
                        {
                            Directory.Move(Path.GetFullPath(File), CurrentDirectory + "\\" + Path.GetFileName(File));
                        }
                        catch (Exception)
                        {
                            string[] Name = File.Split('.');
                            string NewName = Name[0] + " (" + i++ + ")." + Name[1];
                            Directory.Move(Path.GetFullPath(File), CurrentDirectory + "\\" + Path.GetFileName(NewName));
                        }
                    }
                }
            }
            else return;
        }
    }
}

