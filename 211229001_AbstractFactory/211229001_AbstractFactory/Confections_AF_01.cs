using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public class Confections_AF_01:Products_AF_01
    {
        public Confections_AF_01(int code, string ProductName, int category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Confections_AF_01()
        {
        }
    }
}
