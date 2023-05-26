using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_LSP
{
    public interface ICustomerTransactions_LSP_01
    {
        public void LogOut(int UserNo, List<Customer_LSP_01> CustomerList);

        public void Buy(int UserCode, List<Products_LSP_01> ProductsList, List<Customer_LSP_01> CustomerList);

        public void Shipping(Customer_LSP_01 customer);
        public void ShowAccount(int Usercode, List<Customer_LSP_01> CustomerList);

    }
}
