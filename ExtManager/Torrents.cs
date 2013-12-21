using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
	public class Torrents
	{
		private const string ExtFolder = "Torrents\\";

		#region Torrent Extensions

		private static string[] TorrentExtensions =
			{
			   "torrent"
			};

		#endregion Torrent Extensions

		public static List<string> Extensions = new List<string>(TorrentExtensions);

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