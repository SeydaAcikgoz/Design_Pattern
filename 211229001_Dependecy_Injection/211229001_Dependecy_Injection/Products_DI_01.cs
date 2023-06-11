using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public class Products_DI_01: IProduct_DI_01, IProductTransactions_DI_01
    {
        public int Code;
        public string ProductName;
        public string CategoryType;
        public int Stock;
        public double Price;
        public bool login = false;

        public List<Products_DI_01> ProductsList = new List<Products_DI_01>();
        public List<Products_DI_01> basket = new List<Products_DI_01>();

        IProductCategory_DI_01 Category;
        public Products_DI_01()
        {
        }

        public Products_DI_01(IProductCategory_DI_01 category)
        {
            this.Category = category;
        }

        public Products_DI_01(int code, string ProductName, string category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }
        public void CreateProductList()
        {
            IProductCategory_DI_01 category1=new Beverages_DI_01();
            IProduct_DI_01 product=new Products_DI_01(category1);

            Products_DI_01 product1 =product.CreateBeverages(101, "Chai", "Beverages", 39, 18);
            ProductsList.Add(product1);
            Products_DI_01 product2 = product.CreateBeverages(102, "Chang", "Beverages", 17, 19);
            ProductsList.Add(product2);
            Products_DI_01 product3 = product.CreateBeverages(103, "Guarana Fantastica", "Beverages", 20, 4.5);
            ProductsList.Add(product3);

            IProductCategory_DI_01 category2 = new Confections_DI_01();
            IProduct_DI_01 productt = new Products_DI_01(category2);
            Products_DI_01 product4 = productt.CreateConfectionns(201, "Konbu", "Confections", 24, 6);
            ProductsList.Add(product4);
            Products_DI_01 product5 = productt.CreateConfectionns(202, "Pavlova", "Confections", 29, 17.45);
            ProductsList.Add(product5);
            Products_DI_01 product6 = productt.CreateConfectionns(203, "Sir Rodney's Marmalade", "Confections", 40, 81);
            ProductsList.Add(product6);

            IProductCategory_DI_01 category3 = new GrainsCereals_DI_01();
            IProduct_DI_01 producttt = new Products_DI_01(category3);
            Products_DI_01 product7 = producttt.CreateGrainsCereals(301, "Ikura", "GrainsCereals", 31, 31);
            ProductsList.Add(product7);
            Products_DI_01 product8 = producttt.CreateGrainsCereals(302, "Tofu", "GrainsCereals", 35, 25.25);
            ProductsList.Add(product8);
            Products_DI_01 product9 = producttt.CreateGrainsCereals(303, "Tunnbröd", "GrainsCereals", 61, 9);
            ProductsList.Add(product9);
        }

        public Beverages_DI_01 CreateBeverages(int code, string ProductName, string category, int Stock, double Price)
        {
            Beverages_DI_01 beverages = new Beverages_DI_01(code, ProductName, category, Stock, Price);
            return beverages;
        }

        public Confections_DI_01 CreateConfectionns(int code, string ProductName, string category, int Stock, double Price)
        {
            Confections_DI_01 confections = new Confections_DI_01(code, ProductName, category, Stock, Price);
            return confections;
        }

        public GrainsCereals_DI_01 CreateGrainsCereals(int code, string ProductName, string category, int Stock, double Price)
        {
            GrainsCereals_DI_01 grainsCereals = new GrainsCereals_DI_01(code, ProductName, category, Stock, Price);
            return grainsCereals;
        }



        public void LogIn(int cod, string email, string password, List<Customer_DI_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_DI_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");

        }
        public void LogInControl(string email, string password, Customer_DI_01 customer)
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

        public void LogOut(int UserNo, List<Customer_DI_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " logged out");
        }


        public void Buy(int UserCode, List<Products_DI_01> ProductsList, List<Customer_DI_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " bought ");
        }

        public void Shipping(Customer_DI_01 customer)
        {
            Console.WriteLine(this.GetType().ToString() + " shipping ");
        }

        public void StockControl(Products_DI_01 products)
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


        public void AddBasket(int USerCode, int ProductCode, List<Products_DI_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_DI_01 products)
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
            basket.ForEach(delegate (Products_DI_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void FindPrice(int ProductCode, List<Products_DI_01> ProductsList)
        {

            bool product = false;
            ProductsList.ForEach(delegate (Products_DI_01 products)
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


        public void FindStock(int ProductCode, List<Products_DI_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_DI_01 products)
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

        public void ShowAccount(int Usercode, List<Customer_DI_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " show account");
        }

        public void ShowProductsCategory(string category, List<Products_DI_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_DI_01 products)
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
