using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Anti_DIP
{
    public class Products_Anti_DIP_01 : ITransactions_Anti_DIP_01
    {
        public int Code;
        public string ProductName;
        public int CategoryNo;
        public string CategoryType;
        public int Stock;
        public double Price;
        public bool login = false;

        public List<Products_Anti_DIP_01> ProductsList = new List<Products_Anti_DIP_01>();
        public List<Products_Anti_DIP_01> basket = new List<Products_Anti_DIP_01>();

        public Products_Anti_DIP_01()
        {
        }

        public Products_Anti_DIP_01(int code, string ProductName, int CategoryNo, string category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryNo = CategoryNo;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }
        public void CreateProductList()
        {

            Products_Anti_DIP_01 product1 = new Beverages_Anti_DIP_01(101, "Chai",1, "Beverages", 39, 18);
            ProductsList.Add(product1);
            Products_Anti_DIP_01 product2 = new Beverages_Anti_DIP_01(102, "Chang",1, "Beverages", 17, 19);
            ProductsList.Add(product2);
            Products_Anti_DIP_01 product3 = new Beverages_Anti_DIP_01(103, "Guarana Fantastica",1, "Beverages", 20, 4.5);
            ProductsList.Add(product3);
            Products_Anti_DIP_01 product4 = new Confections_Anti_DIP_01(201, "Konbu",2, "Confections", 24, 6);
            ProductsList.Add(product4);
            Products_Anti_DIP_01 product5 = new Confections_Anti_DIP_01(202, "Pavlova",2, "Confections", 29, 17.45);
            ProductsList.Add(product5);
            Products_Anti_DIP_01 product6 = new Confections_Anti_DIP_01(203, "Sir Rodney's Marmalade",2, "Confections", 40, 81);
            ProductsList.Add(product6);
            Products_Anti_DIP_01 product7 = new GrainsCereals_Anti_DIP_01(301, "Ikura",3, "GrainsCereals", 31, 31);
            ProductsList.Add(product7);
            Products_Anti_DIP_01 product8 = new GrainsCereals_Anti_DIP_01(302, "Tofu",3, "GrainsCereals", 35, 25.25);
            ProductsList.Add(product8);
            Products_Anti_DIP_01 product9 = new GrainsCereals_Anti_DIP_01(303, "Tunnbröd",3, "GrainsCereals", 61, 9);
            ProductsList.Add(product9);


        }

        public void LogIn(int cod, string email, string password, List<Customer_Anti_DIP_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_Anti_DIP_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");

        }
        public void LogInControl(string email, string password, Customer_Anti_DIP_01 customer)
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

        public void LogOut(int UserNo, List<Customer_Anti_DIP_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " logged out");
        }


        public void Buy(int UserCode, List<Products_Anti_DIP_01> ProductsList, List<Customer_Anti_DIP_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " bought ");
        }

        public void Shipping(Customer_Anti_DIP_01 customer)
        {
            Console.WriteLine(this.GetType().ToString() + " shipping ");
        }

        public void StockControl(Products_Anti_DIP_01 products)
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


        public void AddBasket(int USerCode, int ProductCode, List<Products_Anti_DIP_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_Anti_DIP_01 products)
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
            basket.ForEach(delegate (Products_Anti_DIP_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void FindPrice(int ProductCode, List<Products_Anti_DIP_01> ProductsList)
        {

            bool product = false;
            ProductsList.ForEach(delegate (Products_Anti_DIP_01 products)
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


        public void FindStock(int ProductCode, List<Products_Anti_DIP_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_Anti_DIP_01 products)
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

        public void ShowAccount(int Usercode, List<Customer_Anti_DIP_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " show account");
        }

        public void ShowProductsCategory(int category, List<Products_Anti_DIP_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_Anti_DIP_01 products)
            {
                if (products.CategoryNo == category)
                {
                    Category = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!Category) Console.WriteLine("Category not found");
        }


    }
}
