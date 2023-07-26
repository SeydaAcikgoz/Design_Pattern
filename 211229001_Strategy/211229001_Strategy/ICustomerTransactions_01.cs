using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public interface ICustomerTransactions_01
    {
        public void LogOut(int UserNo, List<Customer_01> CustomerList);
        public void Buy(int UserCode, List<Products_01> ProductsList, List<Customer_01> CustomerList);
        public void Shipping(Customer_01 customer);
        public void ShowAccount(int Usercode, List<Customer_01> CustomerList);

    }
}
