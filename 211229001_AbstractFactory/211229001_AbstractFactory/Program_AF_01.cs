using _211229001_AbstractFactory;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace _211229001_FM_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer_AF_01 customer = new Customer_AF_01();
            Products_AF_01 product = new Products_AF_01();

            ICustomerFactory_AF_01 customerFactory = new CustomerFactory_AF_01();
            ClientCustomer_AF_01 client = new ClientCustomer_AF_01(customerFactory, customer.CustomerList);
            
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
            product.ShowProductsCategory(1, product.ProductsList);

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
            customer.ShowProductsCategory(1, product.ProductsList);
            Console.WriteLine();
            customer.LogOut(1, customer.CustomerList);
        }
    }
}
