using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
    public class Images
    {
        private const string ExtFolder = "Images\\";

        #region Image Extensions

        private static string[] ImageExtensions =
            {
                "iso",
                "img",
                "nrg"
            };

        #endregion Image Extensions

        public static List<string> Extensions = new List<string>(ImageExtensions);

        public void Sort(Sorter Sorter)
        {
            Sorter.CreateFolder(ExtFolder);
            foreach (string Extension in Extensions)
                Sorter.ByExtension(Extension, ExtFolder);
            Sorter.Check(ExtFolder);
        }

        public void Unsort(UnSorter UnSorter)
        {
            UnSorter.ByFolder(ExtFolder);
            UnSorter.Check(ExtFolder);
        }
    }
}