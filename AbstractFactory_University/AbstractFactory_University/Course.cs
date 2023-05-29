using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public class Course
    {
        private int kredi;
        public Course(int kredi)
        {
            this.kredi = kredi;
        }

        public int KrediHesapla()
        {
            return kredi * 50;
        }

        public int KrediHesapla2()
        {
            return kredi * 5;
        }
    }
}
