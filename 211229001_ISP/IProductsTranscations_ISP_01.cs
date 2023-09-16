using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_ISP
{
    public interface IProductsTranscations_ISP_01
    {
        public void LogIn(int cod, string email, string password, List<Customer_ISP_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<Products_ISP_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<Products_ISP_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_ISP_01> ProductsList);
        public void ShowProductsCategory(CategoryType category, List<Products_ISP_01> ProductsList);
    }
}
