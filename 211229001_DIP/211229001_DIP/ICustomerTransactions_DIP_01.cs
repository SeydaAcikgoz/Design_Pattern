using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_DIP
{
    public interface ICustomerTransactions_DIP_01
    {
        public void LogOut(int UserNo, List<Customer_DIP_01> CustomerList);
        public void Buy(int UserCode, List<Products_DIP_01> ProductsList, List<Customer_DIP_01> CustomerList);
        public void Shipping(Customer_DIP_01 customer);
        public void ShowAccount(int Usercode, List<Customer_DIP_01> CustomerList);

    }
}
