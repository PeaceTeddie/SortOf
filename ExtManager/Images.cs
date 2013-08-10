using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingEngine;

namespace ExtManager
{
    public class Images
    {
        Sorter Sorter = new Sorter();
        UnSorter UnSorter = new UnSorter();

        const string Folder = "Images";

        #region Image Extensions
        static string[] ImageExtensions =
            {              
                "iso",
                "img",
                "nrg"
            };
        #endregion

        static List<string> Extensions = new List<string>(ImageExtensions);

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
