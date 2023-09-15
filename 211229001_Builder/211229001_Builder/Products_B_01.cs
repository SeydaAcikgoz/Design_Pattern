using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Builder
{
    public partial class Products_B_01 : IProductTransactions_B_01
    {
        public int Code;
        public string ProductName;
        public string CategoryType;
        public int Stock;
        public double Price;
        public bool login = false;

        public List<Products_B_01> ProductsList = new List<Products_B_01>();
        public List<Products_B_01> basket = new List<Products_B_01>();

        public
            Products_B_01()
        {
        }
        
        public Products_B_01(BuilderProduct builderProduct)
        {
            this.Code = builderProduct.Code;
            this.ProductName = builderProduct.ProductName;
            this.CategoryType = builderProduct.CategoryType;
            this.Stock = builderProduct.Stock;
            this.Price = builderProduct.Price;
        }

        public void CreateProductList()
        {
            Products_B_01.BuilderProduct builder = new Products_B_01.BuilderProduct(101, "Chai", "Beverages");
            builder.AddStock(39);
            builder.AddPrice(18);
            Products_B_01 product1 = builder.Build();
            ProductsList.Add(product1);

            builder = new Products_B_01.BuilderProduct(102, "Chang", "Beverages");
            builder.AddStock(17);
            builder.AddPrice(19);
            Products_B_01 product2 = builder.Build();
            ProductsList.Add(product2);
            
            builder = new Products_B_01.BuilderProduct(103, "Guarana Fantastica", "Beverages");
            builder.AddStock(20);
            builder.AddPrice(4.5);
            Products_B_01 product3 = builder.Build();
            ProductsList.Add(product3);
            
            builder = new Products_B_01.BuilderProduct(201, "Konbu", "Confections");
            builder.AddStock(24);
            builder.AddPrice(6);
            Products_B_01 product4 = builder.Build();
            ProductsList.Add(product4);

            builder = new Products_B_01.BuilderProduct(202, "Pavlova", "Confections");
            builder.AddStock(29);
            builder.AddPrice(17.45);
            Products_B_01 product5 = builder.Build();
            ProductsList.Add(product5);

            builder = new Products_B_01.BuilderProduct(203, "Sir Rodney's Marmalade", "Confections");
            builder.AddStock(40);
            builder.AddPrice(81);
            Products_B_01 product6 = builder.Build();
            ProductsList.Add(product6);

            builder = new Products_B_01.BuilderProduct(301, "Ikura", "GrainsCereals");
            builder.AddStock(31);
            builder.AddPrice(31);
            Products_B_01 product7 = builder.Build();
            ProductsList.Add(product7);

            builder = new Products_B_01.BuilderProduct(302, "Tofu", "GrainsCereals");
            builder.AddStock(35);
            builder.AddPrice(25.25);
            Products_B_01 product8 = builder.Build();
            ProductsList.Add(product8);

            builder = new Products_B_01.BuilderProduct(303, "Tunnbröd", "GrainsCereals");
            builder.AddStock(61);
            builder.AddPrice(9);
            Products_B_01 product9 = builder.Build();
            ProductsList.Add(product9);
        }

        public void LogIn(int cod, string email, string password, List<Customer_B_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_B_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");
        }
        
        public void LogInControl(string email, string password, Customer_B_01 customer)
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

        public void LogOut(int UserNo, List<Customer_B_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " logged out");
        }

        public void Buy(int UserCode, List<Products_B_01> ProductsList, List<Customer_B_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " bought ");
        }

        public void Shipping(Customer_B_01 customer)
        {
            Console.WriteLine(this.GetType().ToString() + " shipping ");
        }

        public void StockControl(Products_B_01 products)
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

        public void AddBasket(int USerCode, int ProductCode, List<Products_B_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_B_01 products)
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
            basket.ForEach(delegate (Products_B_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void FindPrice(int ProductCode, List<Products_B_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_B_01 products)
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

        public void FindStock(int ProductCode, List<Products_B_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_B_01 products)
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

        public void ShowAccount(int Usercode, List<Customer_B_01> CustomerList)
        {
            Console.WriteLine(this.GetType().ToString() + " show account");
        }

        public void ShowProductsCategory(string category, List<Products_B_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_B_01 products)
            {
                if (products.CategoryType.Equals(category))
                {
                    Category = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" +products.Price+ "\t" + products.Stock);
                }
            });
            if (!Category) Console.WriteLine("Category not found");
        }
    }
}
