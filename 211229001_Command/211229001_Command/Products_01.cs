using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public class Products_01
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
            ITransactions2_01 transactions=new AddProduct_01();
            transactions.Execute(101, "Chai", "Beverages", 39, 18,ProductsList);
            //transactions.Redo(101, "Chai", "Beverages", 39, 18, ProductsList);
            transactions.Execute(102, "Chang", "Beverages", 17, 19,ProductsList);
            transactions.Execute(103, "Guarana Fantastica", "Beverages", 20, 4.5, ProductsList);
            transactions.Execute(201, "Konbu", "Confections", 24, 6, ProductsList);
            transactions.Execute(202, "Pavlova", "Confections", 29, 17.45, ProductsList);
            transactions.Execute(203, "Sir Rodney's Marmalade", "Confections", 40, 81, ProductsList);
            transactions.Execute(301, "Ikura", "GrainsCereals", 31, 31, ProductsList);
            transactions.Execute(302, "Tofu", "GrainsCereals", 35, 25.25, ProductsList);
            transactions.Execute(303, "Tunnbröd", "GrainsCereals", 61, 9, ProductsList);
        }
    
        public void Create(int code, string ProductName, string category, int Stock, double Price, List<Products_01> ProductsList)
        {
            Products_01 product = new Products_01( code,  ProductName,  category,  Stock,  Price);
            ProductsList.Add(product);
        }

        public void Remove(List<Products_01> ProductsList)
        {
            ProductsList.RemoveAt((ProductsList.Count) - 1);
        }

        public void Buy(int product, List<Products_01> ProductsList)
        {
            ProductsList.ForEach(delegate (Products_01 products)
            {
                if (products.Code==product)
                {
                    if (products.Stock >= 1)
                    {
                        products.Stock--;
                        basket.Add(products);
                    }
                    else
                        throw new NotEnoughAmountException_01();
                }
            }); 
        }

        public void Return(int product, List<Products_01> ProductsList)
        {
            ProductsList.ForEach(delegate (Products_01 products)
            {
                if (products.Code==product)
                {
                    basket.Remove(products);
                    products.Stock++;
                    
                }
            });
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

        public void ShowAccount(int Usercode, List<Customer_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " show account");
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
