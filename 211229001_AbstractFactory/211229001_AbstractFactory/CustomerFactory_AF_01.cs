using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public class CustomerFactory_AF_01:ICustomerFactory_AF_01
    {
        public BronzCustomer_AF_01 CreateBronzCustomer(List<Customer_AF_01> CustomerList)
        {
            BronzCustomer_AF_01 bronz = new BronzCustomer_AF_01(1, "Seyda", "Acikgoz", "Konya", 1230, 15, "Bronz", "seyda@gmail.com", "123Seyda", false);
            CustomerList.Add(bronz);
            return bronz;
        }


        public GoldCustomer_AF_01 CreateGoldCustomer(List<Customer_AF_01> CustomerList)
        {
            GoldCustomer_AF_01 gold = new GoldCustomer_AF_01(2, "Esra", "Tosun", "İstanbul", 1520, 75, "Gold", "esra@gmail.com", "123Esra", false);
            CustomerList.Add(gold);
            return gold;
        }

        public SilverCustomer_AF_01 CreateSilverCustomer(List<Customer_AF_01> CustomerList)
        {
            SilverCustomer_AF_01 silver = new SilverCustomer_AF_01(3, "Saziye", "Dag", "Konya", 1430, 65, "Silver", "saziye@gmail.com", "123Saziye", false);
            CustomerList.Add(silver);
            return silver;
        }

        public StandardCustomer_AF_01 CreateStandardCustomer(List<Customer_AF_01> CustomerList)
        {
            StandardCustomer_AF_01 standard = new StandardCustomer_AF_01(4, "Ali", "Taş", "Ankara", 230, 55, "Standard", "ali@gmail.com", "123Ali", false);
            CustomerList.Add(standard);
            return standard;
        }
    }
}
