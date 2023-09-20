using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_FactoryMethod
{
    public class Beverages_FM_01:Products_FM_01,IBeveragesFactory_FM_01
    {
        public Beverages_FM_01(int code, string ProductName, int CategoryType, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = CategoryType;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Beverages_FM_01()
        {
        }

        public Beverages_FM_01 Create(int code, string ProductName, int category, int Stock, double Price)
        {
            Beverages_FM_01 beverages = new Beverages_FM_01(code,ProductName,category,Stock,Price);
            return beverages;
        }
    }
}
