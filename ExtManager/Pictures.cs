using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
    public class Pictures
    {
        private const string ExtFolder = "Pictures\\";

        #region Picture Extensions

        private static string[] PictureExtensions =
            {
                "jpg",
                "jpeg",
                "gif",
                "png",
                "ico",
                "bmp",
                "psd",
                "tif",
                "tiff",
                "pcx",
                "tga",
                "dib"
            };

        #endregion Picture Extensions

        public static List<string> Extensions = new List<string>(PictureExtensions);

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