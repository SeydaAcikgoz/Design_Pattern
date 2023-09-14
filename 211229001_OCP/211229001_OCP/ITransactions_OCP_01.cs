using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_OCP
{
    public interface ITransactions_OCP_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_OCP_01> CustomerList);
        public void LogOut(int UserNo, List<Customer_OCP_01> CustomerList);
        public void Buy(int UserCode, List<Products_OCP_01> ProductsList, List<Customer_OCP_01> CustomerList);
        public void Shipping(Customer_OCP_01 customer);
        public void AddBasket(int USerCode, int ProductCode, List<Products_OCP_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_OCP_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_OCP_01> ProductsList);
        public void ShowAccount(int Usercode, List<Customer_OCP_01> CustomerList);
        public void ShowProductsCategory(int category, List<Products_OCP_01> ProductsList);
    }
}
