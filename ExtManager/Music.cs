using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingEngine;

namespace ExtManager
{
    public class Music
    {
        Sorter Sorter = new Sorter();
        UnSorter UnSorter = new UnSorter();

        const string Folder = "Music";

        #region Music Extensions
        static string[] MusicExtensions =
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
        #endregion

        static List<string> Extensions = new List<string>(MusicExtensions);

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
