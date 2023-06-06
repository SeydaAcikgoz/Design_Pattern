using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Facade
{
    public class ROM
    {
        private int size;  // Size of ROM in MB

        public ROM(int size)
        {
            this.size = size;
        }

        public byte[] GetOSKernelImage()
        {
            Console.WriteLine("ROM: Kernel image yükleniyor.");
            byte[] kernelImage = new byte[2 * 1024 * 1024];

            return kernelImage;
        }
    }
}
