using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
	public class Ebooks
	{
		private const string ExtFolder = "Ebooks\\";

		#region Ebook Extensions

		private static string[] EbookExtensions =
			{
			};

		#endregion Ebook Extensions

		public static List<string> Extensions = new List<string>(EbookExtensions);

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