using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Anti_SRP
{
    public enum CategoryType
    {
        Beverages = 1, Confections = 2, GrainsCereals = 3
    }
    
    public class Products_Anti_SRP_01
    {
        public int Code;
        public string ProductName;
        public CategoryType categoryType;
        public int Stock;
        public double Price;
        public bool login = false;

        public List<Products_Anti_SRP_01> ProductsList = new List<Products_Anti_SRP_01>();
        public List<Products_Anti_SRP_01> basket = new List<Products_Anti_SRP_01>();

        public Products_Anti_SRP_01()
        {
        }

        public Products_Anti_SRP_01(int code, string ProductName, CategoryType categoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.categoryType = categoryType;
            this.Stock = Stock;
            this.Price = Price;
        }
        
        public void LogIn(int cod, string email, string password, List<Customer_Anti_SRP_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_Anti_SRP_01 customer)
            {
                if (customer.UserNo == cod)
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
            });
            if (!login)
                Console.WriteLine("User not found!");
        }

        public void LogOut(int UserNo, List<Customer_Anti_SRP_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " logged out");
        }

        public void Buy(int UserCode, List<Customer_Anti_SRP_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " bought ");
        }

        public void Shipping(Customer_Anti_SRP_01 customer)
        {
            Console.WriteLine(this.GetType().ToString() + " shipping ");
        }

        public void AddBasket(int USerCode, int ProductCode)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_Anti_SRP_01 products)
            {
                if (products.Code == ProductCode)
                {
                    if (products.Stock > 0)
                    {
                        product = true;
                        basket.Add(products);
                        products.Stock--;
                    }
                    else
                    {
                        Console.WriteLine("Product sold out");
                    }

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
            basket.ForEach(delegate (Products_Anti_SRP_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.categoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void FindPrice(int ProductCode)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_Anti_SRP_01 products)
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

        public void FindStock(int ProductCode)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_Anti_SRP_01 products)
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

        public void ShowAccount(int Usercode, List<Customer_Anti_SRP_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " show account");
        }

        public void ShowProductsCategory(CategoryType category)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_Anti_SRP_01 products)
            {
                if (products.categoryType == category)
                {
                    Category = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!Category) Console.WriteLine("Category not found");
        }
    }
}
