using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public class Profesor
    {
        void DersVer()
        {
            Console.WriteLine(this.GetType() + " ders veriliyor..");
        }
    }
}
