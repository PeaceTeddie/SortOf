using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiscLib
{
    public class Manager
    {
        public CatList InitializeCatList()
        {
            CatList CL = new CatList();

            using (XmlTextReader Xread = new XmlTextReader("CatSettings.xml"))
            {
                while (Xread.Read())
                {
                    if (Xread.IsStartElement("Category"))
                        CL.Add(new Category(Xread.GetAttribute(0), bool.Parse(Xread.GetAttribute(1))));

                    else if (Xread.IsStartElement("Extension"))
                        CL[CL.Count - 1].Extensions.Add(new Extension(CL[CL.Count - 1], Xread.ReadString()));
                }
            }
            return CL;
        }

        public void SaveCurrentCatList(CatList CL)
        {
            if (File.Exists("CatSettings.xml"))
                File.Delete("CatSettings.xml");

            using (XmlTextWriter Xwrite = new XmlTextWriter("CatSettings.xml", Encoding.UTF8))
            {
                Xwrite.WriteStartDocument();
                Xwrite.WriteWhitespace("\n");
                Xwrite.WriteStartElement("CatSettings");
                foreach (Category C in CL)
                {
                    Xwrite.WriteWhitespace("\n\t");
                    Xwrite.WriteStartElement("Category");
                    Xwrite.WriteAttributeString("Name", C.Name);
                    Xwrite.WriteAttributeString("Active", C.ShouldSort.ToString());

                    foreach (Extension E in C.Extensions)
                    {
                        Xwrite.WriteWhitespace("\n\t\t");
                        Xwrite.WriteElementString("Extension", E.Name);
                    }
                    Xwrite.WriteWhitespace("\n\t");
                    Xwrite.WriteEndElement();
                }
                Xwrite.WriteWhitespace("\n");
                Xwrite.WriteEndElement();
                Xwrite.WriteEndDocument();
            }
        }
    }
}
