using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Vehicle
{
    public class Tramvay_FM : IArac
    {
        private int hiz;

        public Tramvay_FM(string adi, int v)
        {
            Console.WriteLine(adi + " constructor");
        }

        public void Dur()
        {
            Console.WriteLine(this.GetType() + "dur");
        }

        public void HareketEt(int hiz)
        {
            this.hiz = hiz;
            Console.WriteLine(this.GetType() + " HareketEt " + this.hiz);
        }
    }
}
