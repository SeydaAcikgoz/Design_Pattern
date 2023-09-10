using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_LSP
{
    public interface IProductTransactions_LSP_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_LSP_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<Products_LSP_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_LSP_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_LSP_01> ProductsList);
        public void ShowProductsCategory(int category, List<Products_LSP_01> ProductsList);
    }
}
