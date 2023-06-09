using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public interface ICustomerFactory_AF_01
    {
        public BronzCustomer_AF_01 CreateBronzCustomer(List<Customer_AF_01> CustomerList);

        public GoldCustomer_AF_01 CreateGoldCustomer(List<Customer_AF_01> CustomerList);

        public SilverCustomer_AF_01 CreateSilverCustomer(List<Customer_AF_01> CustomerList);

        public StandardCustomer_AF_01 CreateStandardCustomer(List<Customer_AF_01> CustomerList);
    }
}
