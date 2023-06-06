using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Facade
{
    public class RAM
    {
        private BIOS bios;
        private bool kernelLoaded = false;
        private bool osLoaded = false;

        public RAM()
        {
            bios = new BIOS();
            bios.Start();
            double random = 0.5;

            if (random < 0.8)
            {
                kernelLoaded = true;
                osLoaded = true;
            }
        }

        public void LoadDrivers()
        {
            Console.WriteLine("Driver yüklendi.");
        }

        public void StartServices()
        {
            Console.WriteLine("Servisler başladı.");
        }
    }
}
