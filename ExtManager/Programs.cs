using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
    public class Programs
    {
        private const string ExtFolder = "Programs\\";

        #region Program Extensions

        private static string[] ProgramExtensions =
            {
                "exe",
                "msi",
                "bat",
                "pif",
                "cmd",
                "btm"
            };

        #endregion Program Extensions

        public static List<string> Extensions = new List<string>(ProgramExtensions);

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