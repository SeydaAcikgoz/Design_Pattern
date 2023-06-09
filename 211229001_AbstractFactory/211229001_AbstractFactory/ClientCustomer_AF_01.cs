using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public class ClientCustomer_AF_01
    {
        public BronzCustomer_AF_01 bronz;
        public GoldCustomer_AF_01 gold;
        public SilverCustomer_AF_01 silver;
        public StandardCustomer_AF_01 standard;

        public ClientCustomer_AF_01(ICustomerFactory_AF_01 customerFactory, List<Customer_AF_01>CustomerList)
        {
            bronz = customerFactory.CreateBronzCustomer(CustomerList);
            gold = customerFactory.CreateGoldCustomer(CustomerList);
            silver = customerFactory.CreateSilverCustomer(CustomerList);
            standard = customerFactory.CreateStandardCustomer(CustomerList);

        }
    }
}
