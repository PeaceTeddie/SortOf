using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
    public class Others
    {
        private const string ExtFolder = "Others\\";

        private List<string> ExcludedExts = new List<string>();

        public void ExcludeExts(List<string> Exts)
        {
            ExcludedExts.AddRange(Exts);
        }

        public void Sort(Sorter Sorter)
        {
            Sorter.CreateFolder(ExtFolder);
            Sorter.Others(ExcludedExts, ExtFolder);
            Sorter.Check(ExtFolder);
        }

        public void Unsort(UnSorter UnSorter)
        {
            UnSorter.ByFolder(ExtFolder);
            UnSorter.Check(ExtFolder);
        }
    }
}