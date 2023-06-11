using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    internal interface ICustomerTransactions_DI_01
    {
        public void LogOut(int UserNo, List<Customer_DI_01> CustomerList);
        public void Buy(int UserCode, List<Products_DI_01> ProductsList, List<Customer_DI_01> CustomerList);
        public void Shipping(Customer_DI_01 customer);
        public void ShowAccount(int Usercode, List<Customer_DI_01> CustomerList);

    }
}
