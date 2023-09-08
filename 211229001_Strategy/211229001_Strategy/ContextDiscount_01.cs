using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class ContextDiscount_01
    {
        private IMakeADiscount_01 bronz=new BronzCustomer_01();
        private IMakeADiscount_01 gold=new GoldCustomer_01();
        private IMakeADiscount_01 silver=new SilverCustomer_01();
        private IMakeADiscount_01 standard=new StandardCustomer_01();

        public double MakeDiscount(Customer_01 customer, double total)
        {
            if (customer.customerType.Equals("Gold"))
            {
                total=gold.CalculateDiscount(total);
            }
            else if (customer.customerType.Equals("Silver"))
            {
                total = silver.CalculateDiscount(total);
            }
            else if (customer.customerType.Equals("Bronz"))
            {
                total = bronz.CalculateDiscount(total);
            }
            else if (customer.customerType.Equals("Standard"))
            {
                total = standard.CalculateDiscount(total);
            }
            return total;
        }
    }
}
