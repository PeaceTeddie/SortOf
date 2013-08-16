using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingEngine;

namespace ExtManager
{
	public class Others
	{
		Sorter Sorter = new Sorter();
		UnSorter UnSorter = new UnSorter();

		const string Folder = "Others";

		#region Others Extensions
		static string[] OthersExtensions =
			{
			   "*"
			};
		#endregion

		static List<string> Extensions = new List<string>(OthersExtensions);

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
