using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
    public class Documents
    {
        private const string ExtFolder = "Documents\\";

        #region Document Extensions

        private static string[] DocumentExtensions =
            {
                "doc",
                "docx",
                "pdf",
                "xls",
                "xlsx",
                "txt",
                "ppt",
                "pptx",
                "html",
                "htm",
                "php",
                "xml",
                "rtf",
                "log",
                "css"
            };

        #endregion Document Extensions

        public static List<string> Extensions = new List<string>(DocumentExtensions);

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