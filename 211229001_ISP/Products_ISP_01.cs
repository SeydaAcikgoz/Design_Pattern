using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_ISP
{
    public enum CategoryType
    {
        Beverages = 1, Confections = 2, GrainsCereals = 3
    }
    public class Products_ISP_01 : IProductsTranscations_ISP_01
    {
        public int Code;
        public string ProductName;
        public CategoryType categoryType;
        public int Stock;
        public double Price;
        public bool login = false;

        public List<Products_ISP_01> ProductsList = new List<Products_ISP_01>();
        public List<Products_ISP_01> basket = new List<Products_ISP_01>();
        public Products_ISP_01()
        {
        }

        public Products_ISP_01(int code, string ProductName, CategoryType categoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.categoryType = categoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public void CreateProductList()
        {

            Products_ISP_01 product1 = new Products_ISP_01(101, "Chai", CategoryType.Beverages, 39, 18);
            ProductsList.Add(product1);
            Products_ISP_01 product2 = new Products_ISP_01(102, "Chang", CategoryType.Beverages, 17, 19);
            ProductsList.Add(product2);
            Products_ISP_01 product3 = new Products_ISP_01(103, "Guarana Fantastica", CategoryType.Beverages, 20, 4.5);
            ProductsList.Add(product3);
            Products_ISP_01 product4 = new Products_ISP_01(201, "Konbu", CategoryType.Confections, 24, 6);
            ProductsList.Add(product4);
            Products_ISP_01 product5 = new Products_ISP_01(202, "Pavlova", CategoryType.Confections, 29, 17.45);
            ProductsList.Add(product5);
            Products_ISP_01 product6 = new Products_ISP_01(203, "Sir Rodney's Marmalade", CategoryType.Confections, 40, 81);
            ProductsList.Add(product6);
            Products_ISP_01 product7 = new Products_ISP_01(301, "Ikura", CategoryType.GrainsCereals, 31, 31);
            ProductsList.Add(product7);
            Products_ISP_01 product8 = new Products_ISP_01(302, "Tofu", CategoryType.GrainsCereals, 35, 25.25);
            ProductsList.Add(product8);
            Products_ISP_01 product9 = new Products_ISP_01(303, "Tunnbröd", CategoryType.GrainsCereals, 61, 9);
            ProductsList.Add(product9);


        }
        public void LogIn(int cod, string email, string password, List<Customer_ISP_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_ISP_01 customer)
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



        public void AddBasket(int USerCode, int ProductCode, List<Products_ISP_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
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
            basket.ForEach(delegate (Products_ISP_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.categoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void FindPrice(int ProductCode, List<Products_ISP_01> ProductsList)
        {

            bool product = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
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


        public void FindStock(int ProductCode, List<Products_ISP_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
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


        public void ShowProductsCategory(CategoryType category, List<Products_ISP_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
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


