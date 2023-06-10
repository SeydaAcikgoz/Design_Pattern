using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Builder
{
    public class Beverages_B_01:Products_B_01
    {
        public Beverages_B_01(int code, string ProductName, string CategoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = CategoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Beverages_B_01()
        {

        }
    }
}
