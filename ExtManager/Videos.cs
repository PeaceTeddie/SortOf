using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
	public class Videos
	{
		private const string ExtFolder = "Videos\\";

		#region Video Extensions

		private static string[] VideoExtensions =
			{
				"rm",
				"mp4",
				"mpg",
				"mpeg",
				"flv",
				"3gp",
				"rmvb",
				"avi",
				"wmv",
				"mkv",
				"vob",
				"mov"
			};

		#endregion Video Extensions

		public static List<string> Extensions = new List<string>(VideoExtensions);

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