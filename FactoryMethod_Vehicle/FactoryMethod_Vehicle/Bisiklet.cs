using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Vehicle
{
    public class Bisiklet : Arac
    {
        public Bisiklet(string adi)
        {
            Console.WriteLine(adi + " constructor");
        }

        public void HareketEt(int hiz)
        {
            Console.WriteLine(this.GetType() + " HareketEt " + hiz);
        }
    }
}
