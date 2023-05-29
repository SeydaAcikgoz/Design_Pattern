using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public class Schedule
    {
        private int adet;
        public Schedule(int adet)
        {
            this.adet = adet;
        }
        public int DersSayisiHesapla()
        {
            return adet * 3;
        }
    }
}
