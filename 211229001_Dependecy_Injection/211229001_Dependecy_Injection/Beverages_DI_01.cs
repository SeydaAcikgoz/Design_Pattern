using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public class Beverages_DI_01:Products_DI_01, IProductCategory_DI_01
    {
        Products_DI_01 products;
        public Beverages_DI_01(int code, string ProductName, string CategoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = CategoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Beverages_DI_01()
        {

        }

        public Products_DI_01 Create(int code, string ProductName, string category, int Stock, double Price)
        {
            Products_DI_01 beverages=new Beverages_DI_01(code,ProductName,category,Stock,Price);
            return beverages;
        }
    }
}
