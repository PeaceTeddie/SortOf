using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingEngine;

namespace ExtManager
{
	public class Videos
	{
		Sorter Sorter = new Sorter();
		UnSorter UnSorter = new UnSorter();

		const string Folder = "Videos";

		#region Video Extensions
		static string[] VideoExtensions =
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
		#endregion

		static List<string> Extensions = new List<string>(VideoExtensions);

		public void Sort(string CurrentDirectory)
		{
			Sorter.CurrentDirectory = CurrentDirectory;
			Sorter.CreateFolder(Folder);
			foreach (string Extension in Extensions)
				Sorter.ByExtension(Extension, Folder);
			Sorter.Check(Folder);
		}

		public void Unsort(string CurrentDirectory)
		{
			UnSorter.CurrentDirectory = CurrentDirectory;
			foreach (string Extension in Extensions)
				UnSorter.ByFolder(Folder);
			UnSorter.Check(Folder);
		}
	}
}
