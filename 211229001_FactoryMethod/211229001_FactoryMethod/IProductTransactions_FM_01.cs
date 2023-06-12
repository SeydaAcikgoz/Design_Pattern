using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_FactoryMethod
{
    public interface IProductTransactions_FM_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_FM_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<Products_FM_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_FM_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_FM_01> ProductsList);
        public void ShowProductsCategory(int category, List<Products_FM_01> ProductsList);


    }
}
