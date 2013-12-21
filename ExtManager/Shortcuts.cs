using SortingEngine;
using System.Collections.Generic;

namespace ExtManager
{
	public class Shortcuts
	{
		private const string ExtFolder = "Shortcuts\\";

		#region Shortcut Extensions

		private static string[] ShortcutExtensions =
			{
			   "lnk"
			};

		#endregion Shortcut Extensions

		public static List<string> Extensions = new List<string>(ShortcutExtensions);

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