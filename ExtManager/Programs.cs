using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingEngine;

namespace ExtManager
{
    public class Programs
    {
        Sorter Sorter = new Sorter();
        UnSorter UnSorter = new UnSorter();

        const string Folder = "Programs";

        #region Program Extensions
        static string[] ProgramExtensions =
            {               
                "exe",
                "msi",
                "bat",
                "pif",
                "cmd",
                "btm"
            };
        #endregion

        static List<string> Extensions = new List<string>(ProgramExtensions);

        public void Sort(string CurrentDirectory)
        {
            Sorter.CurrentDirectory = CurrentDirectory;
            Sorter.CreateFolder(Folder);
            foreach (string Extension in Extensions)
                Sorter.ByExtension(Extension, Folder);
            Sorter.Check(Folder);
        }
    }
}
