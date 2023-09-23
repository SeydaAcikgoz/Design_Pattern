using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public interface ICustomerTransactions_AF_01
    {
        public void LogOut(int UserNo, List<Customer_AF_01> CustomerList);
        public void Buy(int UserCode, List<Products_AF_01> ProductsList, List<Customer_AF_01> CustomerList);
        public void Shipping(Customer_AF_01 customer);
        public void ShowAccount(int Usercode, List<Customer_AF_01> CustomerList);
    }
}
