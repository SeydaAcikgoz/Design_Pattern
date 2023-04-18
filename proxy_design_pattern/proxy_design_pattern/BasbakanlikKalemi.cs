using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_design_pattern
{
    public class BasbakanlikKalemi
    {
        private IBasbakan basbakan;
        
        public BasbakanlikKalemi(IBasbakan basbakan)
        {
            this.basbakan = new VekilBasbakan(basbakan);
        }

        public IBasbakan BanaBasbakaniBagla()
        {
            Console.WriteLine("kalemi:tabi efendim");
            return basbakan;
        }
    }
}
