using System;
using System.IO;
using System.Linq;

namespace SortingEngine
{
    public class UnSorter
    {
        public string CurrentDirectory { get; set; }
        private string ActiveDirectory { get; set; }

        public void Check(string ExtFolder)
        {
            ActiveDirectory = CurrentDirectory + ExtFolder;

            if (Directory.Exists(ActiveDirectory))
            {
                int FileCount = Directory.GetFiles(ActiveDirectory).Count();

                if (FileCount == 0)
                    Directory.Delete(ActiveDirectory);
                else return;
            }
            else return;
        }

        public void ByFolder(string ExtFolder)
        {
            ActiveDirectory = CurrentDirectory + ExtFolder;

            if (Directory.Exists(ActiveDirectory))
            {
                string[] Files = Directory.GetFiles(ActiveDirectory, "*", SearchOption.TopDirectoryOnly);

                int FileCount = Files.Count();
                if (FileCount > 0)
                {
                    foreach (string File in Files)
                    {
                        try
                        {
                            Directory.Move(Path.GetFullPath(File), CurrentDirectory + Path.GetFileName(File));
                        }
                        catch (Exception E)
                        {
                            if (E.Equals(new IOException()))
                                return;
                            else
                            {
                                int DupFiles = Directory.GetFiles(CurrentDirectory, Path.GetFileName(File), SearchOption.TopDirectoryOnly).Count();
                                string[] Name = File.Split('.');
                                string NewName = Name[0] + " (" + DupFiles++ + ")." + Name[1];
                                Directory.Move(Path.GetFullPath(File), CurrentDirectory + Path.GetFileName(NewName));
                            }
                        }
                    }
                }
            }
            else return;
        }
    }
}