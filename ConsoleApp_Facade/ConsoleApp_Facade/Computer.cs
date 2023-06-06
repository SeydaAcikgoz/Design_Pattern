using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Facade
{
    public class Computer
    {
        private CPU cpu;
        private RAM ram;
        private HDD hd;
        private Display display;

        public Computer()
        {
            cpu = new CPU();
            ram = new RAM();
            hd = new HDD();
            display = new Display();
        }

        public void Start()
        {
            cpu.Start();
            hd.Start();

            ram.LoadDrivers();
            ram.StartServices();
            display.Start();
            Console.WriteLine("Computer kurulum tamamlandı.");
        }
    }
}
