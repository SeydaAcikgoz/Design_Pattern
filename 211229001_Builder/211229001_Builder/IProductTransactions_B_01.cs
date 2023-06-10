using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Builder
{
    public interface IProductTransactions_B_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_B_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<Products_B_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_B_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_B_01> ProductsList);
        public void ShowProductsCategory(string category, List<Products_B_01> ProductsList);

    }
}
