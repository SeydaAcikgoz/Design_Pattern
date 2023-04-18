using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_design_pattern
{
    public class VekilBasbakan:IBasbakan
    {
        private IBasbakan gercekBasbakan;

        public VekilBasbakan(IBasbakan gercekBasbakan)
        {
            this.gercekBasbakan = gercekBasbakan;
        }

        public void DertDinle(string dert)
        {
            bool ayikla = Ayikla(dert);
            if (ayikla)
            {
                Ilet(dert);
            }
        }

        public void IsBul(string kime)
        {
            Console.WriteLine("vekil basbakan:is bulunacak");
        }

        private bool Ayikla(string dert)
        {
            bool b = true;
            return b;
        }

        private void Ilet(string dert)
        {
            gercekBasbakan.DertDinle(dert);
        }

        
    }
}
