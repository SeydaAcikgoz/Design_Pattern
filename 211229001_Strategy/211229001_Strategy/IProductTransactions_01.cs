using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public interface IProductTransactions_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<Products_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_01> ProductsList);
    }
}
