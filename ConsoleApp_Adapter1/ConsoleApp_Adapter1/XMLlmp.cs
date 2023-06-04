using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Adapter1
{
    public class XMLImp : IXML
    {
        public void Write()
        {
            Console.WriteLine("Xml dosya yaziliyor");
        }
        public void Read()
        {
            Console.WriteLine("Xml dosya okunuyor..");
        }
    }
}
