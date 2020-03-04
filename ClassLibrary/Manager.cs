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

        /*public void DeleteCat(Category Cat)
        {
            using (XmlTextWriter XWrite = new XmlTextWriter("CatSettings.xml", Encoding.UTF8))
            {
                using (XmlTextReader XRead = new XmlTextReader("CatSettings.xml"))
                    while (XRead.Read())
                    {
                        if (XRead.IsStartElement("Category"))
                        {
                                  if(Cat.Name == XRead.GetAttribute(0))
                                      XWrite.

                        }
                    }
            }
        } */
    }
}
