﻿using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
	public class Archives
	{

		private const string ExtFolder = "Archives\\";

		#region Archive Extensions

		private static string[] ArchiveExtensions =
		{
			"zip",
			"rar",
			"7z",
			"ace",
			"cab",
			"tar",
			"jar",
			"pak",
			"pk3",
			"pk4",
			"wad"
		};

		#endregion Archive Extensions

		public static List<string> Extensions = new List<string>(ArchiveExtensions);

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