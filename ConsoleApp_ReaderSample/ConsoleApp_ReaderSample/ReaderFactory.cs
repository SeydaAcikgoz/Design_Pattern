using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ReaderSample
{
    public class ReaderFactory
    {
        public Reader CreateReader(int index)
        {
            Reader reader = null;

            switch (index)
            {
                case 1: reader = new FileReader(); break;
                case 2: reader = new DBReader(); break;
                case 3: reader = new WebAPIReader();break;
                case 4: reader = new SocketReader(); break;
                default:
                    //reader = new Reader();
                    break;
            }
            return reader;
        }
    }
}
