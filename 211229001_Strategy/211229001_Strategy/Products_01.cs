using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class Products_01:IProductTransactions_01
    {
        public int Code;
        public string ProductName;
        public string CategoryType;
        public int Stock;
        public double Price;
        public bool login = false;

        public List<Products_01> ProductsList = new List<Products_01>();
        public List<Products_01> basket = new List<Products_01>();

        public Products_01()
        {
        }

        public Products_01(int code, string ProductName, string category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }
        
        public void CreateProductList()
        {
           ContextProduct_01 contextProduct=new ContextProduct_01();

            Products_01 product1 = contextProduct.CreateProduct(101, "Chai", 1, 39, 18);
            ProductsList.Add(product1);
            Products_01 product2 = contextProduct.CreateProduct(102, "Chang", 1, 17, 19);
            ProductsList.Add(product2);
            Products_01 product3 = contextProduct.CreateProduct(103, "Guarana Fantastica", 1, 20, 4.5);
            ProductsList.Add(product3);
            Products_01 product4 = contextProduct.CreateProduct(201, "Konbu", 2, 24, 6);
            ProductsList.Add(product4);
            Products_01 product5 = contextProduct.CreateProduct(202, "Pavlova", 2, 29, 17.45);
            ProductsList.Add(product5);
            Products_01 product6 = contextProduct.CreateProduct(203, "Sir Rodney's Marmalade", 2, 40, 81);
            ProductsList.Add(product6);
            Products_01 product7 = contextProduct.CreateProduct(301, "Ikura", 3, 31, 31);
            ProductsList.Add(product7);
            Products_01 product8 = contextProduct.CreateProduct(302, "Tofu", 3, 35, 25.25);
            ProductsList.Add(product8);
            Products_01 product9 = contextProduct.CreateProduct(303, "Tunnbröd", 3, 61, 9);
            ProductsList.Add(product9);
        }

        public void LogIn(int cod, string email, string password, List<Customer_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");

        }
        
        public void LogInControl(string email, string password, Customer_01 customer)
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

        public void StockControl(Products_01 products)
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

        public void AddBasket(int USerCode, int ProductCode, List<Products_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_01 products)
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
            basket.ForEach(delegate (Products_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void FindPrice(int ProductCode, List<Products_01> ProductsList)
        {

            bool product = false;
            ProductsList.ForEach(delegate (Products_01 products)
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


        public void FindStock(int ProductCode, List<Products_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_01 products)
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

        public void ShowProductsCategory(string category, List<Products_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_01 products)
            {
                if (products.CategoryType.Equals(category))
                {
                    Category = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!Category) Console.WriteLine("Category not found");
        }

    }
}
