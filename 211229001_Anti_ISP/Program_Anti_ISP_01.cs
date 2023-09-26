using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _211229001_Anti_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products_Anti_ISP_01> ProductsList = new List<Products_Anti_ISP_01>();
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 101, ProductName = "Chai", categoryType = CategoryType.Beverages, Stock = 39, Price = 18 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 102, ProductName = "Chang", categoryType = CategoryType.Beverages, Stock = 17, Price = 19 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 103, ProductName = "Guarana Fantastica", categoryType = CategoryType.Beverages, Stock = 20, Price = 4.5 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 201, ProductName = "Konbu", categoryType = CategoryType.Confections, Stock = 24, Price = 6 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 202, ProductName = "Pavlova", categoryType = CategoryType.Confections, Stock = 29, Price = 17.45 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 203, ProductName = "Sir Rodney's Marmalade", categoryType = CategoryType.Confections, Stock = 40, Price = 81 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 301, ProductName = "Ikura", categoryType = CategoryType.GrainsCereals, Stock = 31, Price = 31 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 302, ProductName = "Tofu", categoryType = CategoryType.GrainsCereals, Stock = 35, Price = 25.25 });
            ProductsList.Add(new Products_Anti_ISP_01() { Code = 303, ProductName = "Tunnbröd", categoryType = CategoryType.GrainsCereals, Stock = 61, Price = 9 });
            
            List<Customer_Anti_ISP_01> CustomerList = new List<Customer_Anti_ISP_01>();
            CustomerList.Add(new Customer_Anti_ISP_01() { UserNo = 1, UserName = "Seyda", UserSurname = "Acikgoz", Adress = "Konya", UserAmount = 1230, Point = 15, customerType = CustomerType.Bronz, Email = "seyda@gmail.com", Password = "123Seyda", LoginStatus = false });
            
            Products_Anti_ISP_01 product = new Products_Anti_ISP_01();
            product.LogIn(5, "seyda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            product.LogIn(1, "seda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            product.LogIn(1, "seyda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            product.ShowBasket();
            Console.WriteLine();
            product.AddBasket(1, 101, ProductsList);
            product.AddBasket(1, 102, ProductsList);
            Console.WriteLine();
            product.ShowBasket();
            Console.WriteLine();
            product.Buy(1, ProductsList, CustomerList);
            Console.WriteLine();
            product.Buy(1, ProductsList, CustomerList);
            Console.WriteLine();
            product.FindPrice(101, ProductsList);
            Console.WriteLine();
            product.FindPrice(11, ProductsList);
            Console.WriteLine();
            product.FindStock(101, ProductsList);
            Console.WriteLine();
            product.FindStock(11, ProductsList);
            Console.WriteLine();
            product.ShowAccount(1, CustomerList);
            Console.WriteLine();
            product.ShowProductsCategory(CategoryType.Beverages, ProductsList);
            Console.WriteLine();
            product.LogOut(1, CustomerList);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Customer_Anti_ISP_01 customer = new Customer_Anti_ISP_01();
            customer.LogIn(5, "seyda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seyda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.AddBasket(1, 101, ProductsList);
            customer.AddBasket(1, 102, ProductsList);
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.Buy(1, ProductsList, CustomerList);
            Console.WriteLine();
            customer.Buy(1, ProductsList, CustomerList);
            Console.WriteLine();
            customer.FindPrice(101, ProductsList);
            Console.WriteLine();
            customer.FindStock(101, ProductsList);
            Console.WriteLine();
            customer.FindStock(11, ProductsList);
            Console.WriteLine();
            customer.ShowAccount(1, CustomerList);
            Console.WriteLine();
            customer.ShowAccount(11, CustomerList);
            Console.WriteLine();
            customer.ShowProductsCategory(CategoryType.Beverages, ProductsList);
            Console.WriteLine();
            customer.LogOut(1, CustomerList);
        }
    }
}
