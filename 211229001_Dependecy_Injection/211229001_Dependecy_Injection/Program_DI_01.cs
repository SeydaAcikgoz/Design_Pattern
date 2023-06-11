using _211229001_Dependecy_Injection;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace _211229001_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer_DI_01 customer = new Customer_DI_01();
            Products_DI_01 product = new Products_DI_01();


            ICustomerCategory_DI_01 category1 = new BronzCustomer_DI_01();
            ICustomer_DI_01 Customer=new Customer_DI_01(category1);
            Customer_DI_01 customer1 = Customer.CreateBronzCustomer(1,"Seyda","Acikgoz","Konya",1230, 15, "Bronz", "seyda@gmail.com", "123Seyda", false);
            customer.CustomerList.Add(customer1);


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
            product.ShowProductsCategory("Beverages", product.ProductsList);
           


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
            customer.ShowProductsCategory("Beverages", product.ProductsList);
            Console.WriteLine();
            customer.LogOut(1, customer.CustomerList);

        }
    }

}
