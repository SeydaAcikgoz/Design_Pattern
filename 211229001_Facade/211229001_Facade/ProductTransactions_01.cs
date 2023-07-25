using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class ProductTransactions_01
    {
        private ProductsBuilder_01 productsBuilder;
        public bool login = false;
        Products_01 product = new Products_01();
       

        public void CreateProductList(List<Products_01> ProductsList)
        {
            productsBuilder = new ProductsBuilder_01(ProductsList);//ürünlerin hepsinin oluşturulduğu yer

        }

        public void StockControl(Products_01 products, List<Products_01> basket)
        {
            if (products.Stock > 0)
            {
                basket.Add(products);
                products.Stock--;
            } else
            {
                Console.WriteLine("Product sold out");
            }
        }

        public void AddBasket(int ProductCode, List<Products_01> ProductsList, List<Products_01> basket)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_01 products)
            {
                if (products.Code == ProductCode)
                {
                    product = true;
                    StockControl(products, basket);

                }
            });
            if (!product)
                Console.WriteLine("Product not found!");
        }

        public void ShowBasket(List<Products_01> basket)
        {
            Console.WriteLine();

            if (basket.Count == 0)
            {
                Console.WriteLine("Basket is empty");
            }
            else
            {
                Console.WriteLine("Basket:");
                basket.ForEach(delegate (Products_01 products)
                {
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");

                });
            }
         }


        public void CalculateBasket(List<Products_01> basket)
        {
            double total = 0;
          
            basket.ForEach(delegate (Products_01 products)
            {
              
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
