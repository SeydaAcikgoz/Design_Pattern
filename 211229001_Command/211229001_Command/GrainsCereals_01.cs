using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public class GrainsCereals_01:Products_01
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
    }
}
