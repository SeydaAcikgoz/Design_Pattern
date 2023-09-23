using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public interface IProductTransactions_AF_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_AF_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<Products_AF_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_AF_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_AF_01> ProductsList);
        public void ShowProductsCategory(int category, List<Products_AF_01> ProductsList);
    }
}
