using _211229001_ISP;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _211229001_Anti_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer_ISP_01 customer = new Customer_ISP_01();
            Products_ISP_01 product = new Products_ISP_01();

            customer.CustomerList.Add(new Customer_ISP_01() { UserNo = 1, UserName = "Seyda", UserSurname = "Acikgoz", Adress = "Konya", UserAmount = 1230, Point = 15, customerType = CustomerType.Bronz, Email = "seyda@gmail.com", Password = "123Seyda", LoginStatus = false });

            product.CreateProductList();
            product.LogIn(5, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            product.LogIn(1, "seda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            product.LogIn(1, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            product.ShowBasket();
            Console.WriteLine();
            product.AddBasket(1, 101, product.ProductsList);
            product.AddBasket(1, 102, product.ProductsList);
            Console.WriteLine();
            product.ShowBasket();
            Console.WriteLine();
            product.FindPrice(101, product.ProductsList);
            Console.WriteLine();
            product.FindPrice(11, product.ProductsList);
            Console.WriteLine();
            product.FindStock(101, product.ProductsList);
            Console.WriteLine();
            product.FindStock(11, product.ProductsList);
            Console.WriteLine();
            product.ShowProductsCategory(CategoryType.Beverages, product.ProductsList);
           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            customer.LogIn(5, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.AddBasket(1, 101, product.ProductsList);
            customer.AddBasket(1, 102, product.ProductsList);
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.Buy(1, product.ProductsList, customer.CustomerList);
            Console.WriteLine();
            customer.Buy(1, product.ProductsList, customer.CustomerList);
            Console.WriteLine();
            customer.FindPrice(101, product.ProductsList);
            Console.WriteLine();
            customer.FindStock(101, product.ProductsList);
            Console.WriteLine();
            customer.FindStock(11, product.ProductsList);
            Console.WriteLine();
            customer.ShowAccount(1, customer.CustomerList);
            Console.WriteLine();
            customer.ShowAccount(11, customer.CustomerList);
            Console.WriteLine();
            customer.ShowProductsCategory(CategoryType.Beverages, product.ProductsList);
            Console.WriteLine();
            customer.LogOut(1, customer.CustomerList);
        }
    }
}
