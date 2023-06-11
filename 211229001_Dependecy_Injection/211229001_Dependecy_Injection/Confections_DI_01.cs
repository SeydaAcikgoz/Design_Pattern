using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public class Confections_DI_01 : Products_DI_01, IProductCategory_DI_01
    {
        Products_DI_01 products;
        public Confections_DI_01(int code, string ProductName, string CategoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = CategoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Confections_DI_01()
        {

        }

        public Products_DI_01 Create(int code, string ProductName, string category, int Stock, double Price)
        {
            Confections_DI_01 confections = new Confections_DI_01(code, ProductName, category, Stock, Price);
            return confections;
        }
    }
}
