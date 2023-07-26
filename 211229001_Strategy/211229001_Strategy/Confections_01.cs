using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class Confections_01 : Products_01, IProductCreate_01
    {
        public Confections_01(int code, string ProductName, string CategoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = CategoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Confections_01()
        {

        }

        public Products_01 Create(int code, string ProductName, int Stock, double Price)
        {
            Products_01 confections = new Products_01();
            confections.Code = code;
            confections.ProductName = ProductName;
            confections.CategoryType = "Confections";
            confections.Stock = Stock;
            confections.Price = Price;
            return confections;
        }

    }
}
