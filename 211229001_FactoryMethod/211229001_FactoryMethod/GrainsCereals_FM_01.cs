using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_FactoryMethod
{
    public class GrainsCereals_FM_01:Products_FM_01,IGrainsCerealsFactory_FM_01
    {
        public GrainsCereals_FM_01(int code, string ProductName, int category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }

        public GrainsCereals_FM_01()
        {
        }

        public GrainsCereals_FM_01 Create(int code, string ProductName, int category, int Stock, double Price)
        {
            GrainsCereals_FM_01 grainsCereals = new GrainsCereals_FM_01(code, ProductName, category, Stock, Price);
            return grainsCereals;
        }
    }
}
