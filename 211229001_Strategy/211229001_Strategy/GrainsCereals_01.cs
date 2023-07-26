using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class GrainsCereals_01:Products_01, IProductCreate_01
    {
        public GrainsCereals_01(int code, string ProductName, string CategoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = CategoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public GrainsCereals_01()
        {
        }

        public Products_01 Create(int code, string ProductName, int Stock, double Price)
        {
            Products_01 grainsCereals = new Products_01();
            grainsCereals.Code = code;
            grainsCereals.ProductName = ProductName;
            grainsCereals.CategoryType = "GrainsCereals";
            grainsCereals.Stock = Stock;
            grainsCereals.Price = Price;
            return grainsCereals;
        }
    }
}
