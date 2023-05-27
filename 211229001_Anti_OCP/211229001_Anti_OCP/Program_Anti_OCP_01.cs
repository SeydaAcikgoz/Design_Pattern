using _211229001_Anti_OCP;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _211229001_Anti_OCP
{
    class Program
    {
        static void Main(string[] args)
        {

            Products_Anti_OCP_01 product = new Products_Anti_OCP_01();
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 101, ProductName = "Chai", categoryType = CategoryType.Beverages, Stock = 39, Price = 18 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 102, ProductName = "Chang", categoryType = CategoryType.Beverages, Stock = 17, Price = 19 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 103, ProductName = "Guarana Fantastica", categoryType = CategoryType.Beverages, Stock = 20, Price = 4.5 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 201, ProductName = "Konbu", categoryType = CategoryType.Confections, Stock = 24, Price = 6 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 202, ProductName = "Pavlova", categoryType = CategoryType.Confections, Stock = 29, Price = 17.45 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 203, ProductName = "Sir Rodney's Marmalade", categoryType = CategoryType.Confections, Stock = 40, Price = 81 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 301, ProductName = "Ikura", categoryType = CategoryType.GrainsCereals, Stock = 31, Price = 31 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 302, ProductName = "Tofu", categoryType = CategoryType.GrainsCereals, Stock = 35, Price = 25.25 });
            product.ProductsList.Add(new Products_Anti_OCP_01() { Code = 303, ProductName = "Tunnbröd", categoryType = CategoryType.GrainsCereals, Stock = 61, Price = 9 });


            Customer_Anti_OCP_01 customer = new Customer_Anti_OCP_01();
            customer.CustomerList.Add(new Customer_Anti_OCP_01() { UserNo = 1, UserName = "Seyda", UserSurname = "Acikgoz", Adress = "Konya", UserAmount = 1230, Point = 15, customerType = CustomerType.Bronz, Email = "seyda@gmail.com", Password = "123Seyda", LoginStatus = false });


            product.LogIn(5, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            product.LogIn(1, "seda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            product.LogIn(1, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            product.ShowBasket();
            Console.WriteLine();
            product.AddBasket(1, 101);
            product.AddBasket(1, 102);
            Console.WriteLine();
            product.ShowBasket();
            Console.WriteLine();
            product.Buy(1, customer.CustomerList);
            Console.WriteLine();
            product.Buy(1, customer.CustomerList);
            Console.WriteLine();
            product.FindPrice(101);
            Console.WriteLine();
            product.FindPrice(11);
            Console.WriteLine();
            product.FindStock(101);
            Console.WriteLine();
            product.FindStock(11);
            Console.WriteLine();
            product.ShowAccount(1, customer.CustomerList);
            Console.WriteLine();
            product.ShowProductsCategory(CategoryType.Beverages);
            Console.WriteLine();
            product.LogOut(1, customer.CustomerList);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            customer.LogIn(5, "seyda@gmail.com", "123Seyda");
            Console.WriteLine();
            customer.LogIn(1, "seda@gmail.com", "123Seyda");
            Console.WriteLine();
            customer.LogIn(1, "seyda@gmail.com", "123Seyda");
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.AddBasket(1, 101, product.ProductsList);
            customer.AddBasket(1, 102, product.ProductsList);
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.Buy(1, product.ProductsList);
            Console.WriteLine();
            customer.Buy(1, product.ProductsList);
            Console.WriteLine();
            customer.FindPrice(101, product.ProductsList);
            Console.WriteLine();
            customer.FindStock(101, product.ProductsList);
            Console.WriteLine();
            customer.FindStock(11, product.ProductsList);
            Console.WriteLine();
            customer.ShowAccount(1);
            Console.WriteLine();
            customer.ShowAccount(11);
            Console.WriteLine();
            customer.ShowProductsCategory(CategoryType.Beverages, product.ProductsList);
            Console.WriteLine();
            customer.LogOut(1);

        }
    }
}
