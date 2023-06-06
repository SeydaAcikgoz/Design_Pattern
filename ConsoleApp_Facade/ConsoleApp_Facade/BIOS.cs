using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Facade
{
    public class BIOS
    {
        private ROM rom;

        public BIOS()
        {
            rom = new ROM(2 * 1024);
            rom.GetOSKernelImage();
        }

        public void Start()
        {
            Console.WriteLine("BIOS: başlatılıyor.");
            rom.GetOSKernelImage();
        }
    }
}
