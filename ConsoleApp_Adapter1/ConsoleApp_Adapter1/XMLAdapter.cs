using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Adapter1
{
    public class XMLAdapter : IJSON //Xml,Json a çevrilir
    {
        public string FileName { get; set; }

        IXML xml;
        
        public XMLAdapter(IXML xml)
        {
            this.xml = xml;
        }


        public void Read1()
        {
            xml.Read();
        }
    }
}
