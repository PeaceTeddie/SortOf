using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
    public class Music
    {
        private const string ExtFolder = "Music\\";

        #region Music Extensions

        private static string[] MusicExtensions =
            {
                "mp3",
                "wma",
                "wav",
                "ogg",
                "mid",
                "midi",
                "flac",
                "acc"
            };

        #endregion Music Extensions

        public static List<string> Extensions = new List<string>(MusicExtensions);

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