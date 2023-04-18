using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_design_pattern
{
    public class Vatandas
    {
        private IBasbakan basbakan;

        public Vatandas(BasbakanlikKalemi kalem)
        {
            basbakan = kalem.BanaBasbakaniBagla();
        }

        public String DerdiniAnlat()
        {
            basbakan.DertDinle("dert buyuk");
            return "o is tamamdir";
        }

        public String IsIste()
        {
            basbakan.IsBul("oglum");
            return "o is bulundu";
        }


    }
}
