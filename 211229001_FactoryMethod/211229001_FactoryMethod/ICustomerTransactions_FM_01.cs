using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_FactoryMethod
{
    public interface ICustomerTransactions_FM_01
    {
        public void LogOut(int UserNo, List<Customer_FM_01> CustomerList);
        public void Buy(int UserCode, List<Products_FM_01> ProductsList, List<Customer_FM_01> CustomerList);
        public void Shipping(Customer_FM_01 customer);
       public void ShowAccount(int Usercode, List<Customer_FM_01> CustomerList);
    }
}
