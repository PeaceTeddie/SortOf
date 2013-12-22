using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortingEngine
{
    public class Sorter
    {
        public string CurrentDirectory { get; set; }
        private string ActiveDirectory { get; set; }

        public void Check(string ExtFolder)
        {
            ActiveDirectory = CurrentDirectory + ExtFolder;

            int FileCount = Directory.GetFiles(ActiveDirectory).Count();
            int FolderCount = Directory.GetDirectories(ActiveDirectory).Count();

            if (FileCount == 0 && FolderCount == 0)
                Directory.Delete(ActiveDirectory);
            else return;            
        }

        public void CreateFolder(string ExtFolder)
        {
            ActiveDirectory = CurrentDirectory + ExtFolder;

            if (!Directory.Exists(ActiveDirectory))
                Directory.CreateDirectory(ActiveDirectory);
        }

        public void ByExtension(string Extension, string ExtFolder)
        {
            ActiveDirectory = CurrentDirectory + ExtFolder;

            string[] Files = Directory.GetFiles(CurrentDirectory, "*." + Extension, SearchOption.TopDirectoryOnly);

            int FileCount = Files.Count();
            if (FileCount > 0)
            {
                foreach (string File in Files)
                {
                    try
                    {
                        Directory.Move(Path.GetFullPath(File), ActiveDirectory + Path.GetFileName(File));
                    }
                    catch (Exception E)
                    {
                        if (E.Equals(new IOException()))
                            return;
                        else
                        {
                            int DupFiles = Directory.GetFiles(ActiveDirectory, Path.GetFileName(File), SearchOption.TopDirectoryOnly).Count();
                            string[] Name = File.Split('.');
                            string NewName = Name[0] + " (" + DupFiles++ + ")." + Name[1];
                            Directory.Move(Path.GetFullPath(File), ActiveDirectory + Path.GetFileName(NewName));
                        }
                    }
                }
            }
        }

        public void Others(List<string> Excluded, string ExtFolder)
        {
            ActiveDirectory = CurrentDirectory + ExtFolder;

            string[] Files = Directory.GetFiles(CurrentDirectory, "*", SearchOption.TopDirectoryOnly);

            if (Files.Count() > 0)
            {
                foreach (string File in Files)
                {
                    if (Excluded.Count() > 0)
                    {
                        foreach (string S in Excluded)
                        {
                            try
                            {
                                if (!File.Contains("." + S))
                                    Directory.Move(Path.GetFullPath(File), ActiveDirectory + Path.GetFileName(File));
                                else return;
                            }
                            catch (Exception E)
                            {
                                if (E.Equals(new IOException()))
                                    return;
                                else
                                {
                                    int DupFiles = Directory.GetFiles(ActiveDirectory, Path.GetFileName(File), SearchOption.TopDirectoryOnly).Count();
                                    string[] Name = File.Split('.');
                                    string NewName = Name[0] + " (" + DupFiles++ + ")." + Name[1];
                                    Directory.Move(Path.GetFullPath(File), ActiveDirectory + Path.GetFileName(NewName));
                                }
                            }
                        }
                    }
                    else 
                    {
                        try
                        {
                            Directory.Move(Path.GetFullPath(File), ActiveDirectory + Path.GetFileName(File));
                        }
                        catch (Exception E)
                        {
                            if (E.Equals(new IOException()))
                                return;
                            else
                            {
                                int DupFiles = Directory.GetFiles(ActiveDirectory, Path.GetFileName(File), SearchOption.TopDirectoryOnly).Count();
                                string[] Name = File.Split('.');
                                string NewName = Name[0] + " (" + DupFiles++ + ")." + Name[1];
                                Directory.Move(Path.GetFullPath(File), ActiveDirectory + Path.GetFileName(NewName));
                            }
                        }
                    }
                }
            }
        }
    }
}