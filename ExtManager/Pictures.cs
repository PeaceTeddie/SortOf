using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingEngine;

namespace ExtManager
{
    public class Pictures
    {
        Sorter Sorter = new Sorter();
        UnSorter UnSorter = new UnSorter();

        const string Folder = "Pictures";

        #region Picture Extensions
        static string[] PictureExtensions =
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
        #endregion

        static List<string> Extensions = new List<string>(PictureExtensions);

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
