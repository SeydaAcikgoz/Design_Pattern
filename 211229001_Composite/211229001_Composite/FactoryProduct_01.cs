using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Composite
{
    public class FactoryProduct_01 : ProductObject_01, ICompositeProduct_01
    {
        public List<ProductObject_01> ProductsList;
        public FactoryProduct_01(int code, string ProductName, string category, int Stock, double Price):base(code, ProductName, category, Stock, Price) {
            ProductsList=new List<ProductObject_01>();
        }
        public void AddProducts(ProductObject_01 product)
        {
            ProductsList.Add(product);
        }


        public void ListProducts()
        {
            Console.WriteLine("\nProduct objects:");

            foreach (ProductObject_01 products in ProductsList)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
            }
        }
    }
}
