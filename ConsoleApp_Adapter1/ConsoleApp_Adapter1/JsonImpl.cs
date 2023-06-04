using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Adapter1
{
    public class JsonImpl : IJSON //JsonImpl->Json implementation u
    {
        
        public string FileName { get; set; }

        
        public void Read1()
        {
            Console.WriteLine(FileName + " Json dosya okunuyor");
        }
    }
}
