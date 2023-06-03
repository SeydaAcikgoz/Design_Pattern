using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection_Engine
{
    public class DizelMotor_DI : IMotor
    {
        public void Baslat()
        {
            Console.WriteLine(" Dizel motor çalıştı");
        }
    }
}
