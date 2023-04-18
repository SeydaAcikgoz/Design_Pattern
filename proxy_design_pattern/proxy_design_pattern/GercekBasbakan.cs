using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_design_pattern
{
    public class GercekBasbakan : IBasbakan
    {
        public void DertDinle(string dert)
        {
            Console.WriteLine("Basbakan:dinliyorum" + dert);
        }

        public void IsBul(string kime)
        {
            Console.WriteLine("Basbakan:IsBul calisiyor. " + kime);
        }
    }
}
