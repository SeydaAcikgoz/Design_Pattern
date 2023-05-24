using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_DIP
{
    public interface IProductsTransactions_DIP_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_DIP_01> CustomerList);
  
        public void AddBasket(int USerCode, int ProductCode, List<Products_DIP_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_DIP_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_DIP_01> ProductsList);
        public void ShowProductsCategory(int category, List<Products_DIP_01> ProductsList);

    }
}
