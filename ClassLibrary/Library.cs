using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MiscLib
{
    public class SetList : List<Setting> { }

    public class CatList : List<Category> { }

    public class ExtList : List<Extension> { }

    public class Category
    {
        public string Name { get; set; }
        public string Folder { get; set; }
        public bool ShouldSort { get; set; }
        public ExtList Extensions = new ExtList();

        public Category(string _Name, bool _Active)
        {
            Name = _Name;
            Folder = _Name + "\\";
            ShouldSort = _Active;
        }
        public void Update(string _Name)
        {
            Name = _Name;
            Folder = _Name + "\\";
            foreach (Extension E in Extensions)
                E.Category = this;
        }
    }

    public class Setting
    {
        public string Name
        {
            get;
            private set;
        }
        public bool Active
        {
            get;
            set;
        }

        public Setting()
        {

        }

        public Setting(string _Name, bool _Active)
        {
            Name = _Name;
            Active = _Active;
        }
    }

    public class Extension
    {
        public Category Category;
        public string Name;

        public Extension()
        {

        }

        public Extension(Category _Catergory, string _Name)
        {
            Category = _Catergory;
            Name = _Name;
        }
    }

    public class FileItem
    {
        public string FullPath
        {
            get;
            set;
        }
        public string Filename
        {
            get;
            set;
        }
        public string Extension
        {
            get;
            set;
        }
        public string NameWithExtension
        {
            get;
            set;
        }

        public FileItem(string FP)
        {
            FullPath = FP;
            Filename = new FileInfo(FP).Name.Split('.')[0];
            Extension = $".{new FileInfo(FP).Name.Split('.')[1]}";
            NameWithExtension = Filename + Extension;
        }
    }
}
