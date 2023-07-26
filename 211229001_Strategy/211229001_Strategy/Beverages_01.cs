using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class Beverages_01: Products_01,IProductCreate_01
    {
        public Beverages_01(int code, string ProductName, string CategoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = CategoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Products_01 Create(int code, string ProductName, int Stock, double Price)
        {
            Products_01 beverages = new Products_01();
            beverages.Code = code;
            beverages.ProductName = ProductName;
            beverages.CategoryType = "Beverages";
            beverages.Stock = Stock;
            beverages.Price = Price;
            return beverages;
        }

        public Beverages_01()
        {
        }
    }
}
