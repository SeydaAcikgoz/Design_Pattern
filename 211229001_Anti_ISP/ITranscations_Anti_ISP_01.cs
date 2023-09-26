using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Anti_ISP
{
    public interface ITranscations_Anti_ISP_01
    {
        public void LogIn(int cod,string email, string password, List<Customer_Anti_ISP_01> CustomerList);
        public void LogOut(int UserNo, List<Customer_Anti_ISP_01> CustomerList);
        public void Buy(int UserCode, List<Products_Anti_ISP_01> ProductsList, List<Customer_Anti_ISP_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<Products_Anti_ISP_01> ProductsList);
        public void ShowBasket();
        public void Shipping(Customer_Anti_ISP_01 customer);
        public void FindPrice(int ProductCode, List<Products_Anti_ISP_01> ProductsList);
        public void FindStock(int ProductCode, List<Products_Anti_ISP_01> ProductsList);
        public void ShowAccount(int Usercode, List<Customer_Anti_ISP_01> CustomerList);
        public void ShowProductsCategory(CategoryType category, List<Products_Anti_ISP_01> ProductsList);
    }
}
