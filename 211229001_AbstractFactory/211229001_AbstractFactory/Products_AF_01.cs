using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public class Products_AF_01 : IProductTransactions_AF_01
    {
        public int Code;
        public string ProductName;
        public int CategoryType;
        public int Stock;
        public double Price;
        public bool login = false;

        public List<Products_AF_01> ProductsList = new List<Products_AF_01>();
        public List<Products_AF_01> basket = new List<Products_AF_01>();

       
        public Products_AF_01(int code, string ProductName, int category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }
         public Products_AF_01()
        {
        }

       
        public void CreateProductList()
        {
            IProductFactory_AF_01 productFactory = new ProductFactory_AF_01();
            ClientProduct_AF_01 client = new ClientProduct_AF_01(productFactory,ProductsList);
           
        }

        public void LogIn(int cod, string email, string password, List<Customer_AF_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_AF_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");

        }
        public void LogInControl(string email, string password, Customer_AF_01 customer)
        {

            if (customer.Email.Equals(email) && customer.Password.Equals(password))
            {
                customer.LoginStatus = true;
                login = true;
                Console.WriteLine("Successfully logged in.Wellcome " + customer.UserName);
                return;
            }
            else
            {
                Console.WriteLine("Email or Password wrong");
                return;
            }

        }

        public void LogOut(int UserNo, List<Customer_AF_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " logged out");
        }


        public void Buy(int UserCode, List<Products_AF_01> ProductsList, List<Customer_AF_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " bought ");
        }

        public void Shipping(Customer_AF_01 customer)
        {
            Console.WriteLine(this.GetType().ToString() + " shipping ");
        }

        public void StockControl(Products_AF_01 products)
        {

            if (products.Stock > 0)
            {
                basket.Add(products);
                products.Stock--;
            }
            else
            {
                Console.WriteLine("Product sold out");
            }

        }


        public void AddBasket(int USerCode, int ProductCode, List<Products_AF_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_AF_01 products)
            {
                if (products.Code == ProductCode)
                {
                    product = true;
                    StockControl(products);

                }
            });
            if (!product)
                Console.WriteLine("Product not found!");
        }

        public void ShowBasket()
        {
            double total = 0;
            if (basket.Count == 0)
            {
                Console.WriteLine("Basket is empty");
            }
            basket.ForEach(delegate (Products_AF_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void FindPrice(int ProductCode, List<Products_AF_01> ProductsList)
        {

            bool product = false;
            ProductsList.ForEach(delegate (Products_AF_01 products)
            {
                if (products.Code == ProductCode)
                {
                    product = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Price);
                }
            });
            if (!product)
                Console.WriteLine("Product not found!");
        }


        public void FindStock(int ProductCode, List<Products_AF_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_AF_01 products)
            {
                if (products.Code == ProductCode)
                {
                    product = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!product)
                Console.WriteLine("Product not found!");
        }

        public void ShowAccount(int Usercode, List<Customer_AF_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " show account");
        }

        public void ShowProductsCategory(int category, List<Products_AF_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_AF_01 products)
            {
                if (products.CategoryType == category)
                {
                    Category = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!Category) Console.WriteLine("Category not found");
        }

    }
}
