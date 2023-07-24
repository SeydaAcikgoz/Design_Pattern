using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Composite
{
    public class ProductObject_01 : IProduct_01
    {
        public int Code;
        public string ProductName;
        public string CategoryType;
        public int Stock;
        public double Price;
        public bool login = false;


        public List<ProductObject_01> basket = new List<ProductObject_01>();

        public ProductObject_01()
        {
        }
        
        public ProductObject_01(int code, string ProductName, string category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }

        public void LogIn(int cod, string email, string password, List<CustomerObject_01> CustomerList)
        {
            CustomerList.ForEach(delegate (CustomerObject_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");

        }

        public void LogInControl(string email, string password, CustomerObject_01 customer)
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
        public void AddBasket(int USerCode, int ProductCode, List<ProductObject_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
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
        public void StockControl(ProductObject_01 products)
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

        public void FindPrice(int ProductCode, List<ProductObject_01> ProductsList)
        {

            bool product = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
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
        IProduct_01 IProduct_01;
        public void FindStock(int ProductCode, List<ProductObject_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
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

        public void ShowBasket()
        {
            double total = 0;
            if (basket.Count == 0)
            {
                Console.WriteLine("Basket is empty");
            }
            basket.ForEach(delegate (ProductObject_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void ShowProductsCategory(string category, List<ProductObject_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
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
