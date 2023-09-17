using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace _211229001_Command
{

    class Program
    {
        static void Main(string[] args)
        {
            Products_01 products = new Products_01();
            Customer_01 customer = new Customer_01();

            customer.CustomerList.Add(new Customer_01() { UserNo = 1, UserName = "Seyda", UserSurname = "Acikgoz", Adress = "Konya", UserAmount = 1230, Point = 15, customerType = "Bronz", Email = "seyda@gmail.com", Password = "123Seyda", LoginStatus = false });

            products.CreateProductList();//liste oluşturuldu
            
            customer.LogIn(5, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seyda@gmail.com", "123Seyda", customer.CustomerList);
            Console.WriteLine();
    
            ITransactions_01 transaction = new Buy_01();
            transaction.Execute(101, products.ProductsList);
            transaction.Execute(201, products.ProductsList);
            transaction.Execute(301, products.ProductsList);
            
            ITransactions_01 transaction2 = new Return_01();
            transaction2.Execute(101, products.ProductsList);
            transaction2.Redo(101,products.ProductsList);
            transaction2.Undo(products.ProductsList);
           
            
            customer.AddBasket(1, 101, products.ProductsList);
            customer.AddBasket(1, 103, products.ProductsList);
            customer.AddBasket(1, 201, products.ProductsList);
            customer.AddBasket(1, 301, products.ProductsList);
            customer.AddBasket(1, 102, products.ProductsList);
            customer.Buy(1, products.ProductsList, customer.CustomerList);
            Console.WriteLine();
            customer.Buy(1, products.ProductsList, customer.CustomerList);
            Console.WriteLine();
            customer.FindPrice(101, products.ProductsList);
            Console.WriteLine();
            customer.FindStock(101, products.ProductsList);
            Console.WriteLine();
            customer.FindStock(11, products.ProductsList);
            Console.WriteLine();
            customer.ShowAccount(1, customer.CustomerList);
            Console.WriteLine();
            customer.ShowAccount(11, customer.CustomerList);
            Console.WriteLine();
            customer.ShowProductsCategory("Beverages", products.ProductsList);
            Console.WriteLine();
            customer.LogOut(1, customer.CustomerList);
        }
    }
}
