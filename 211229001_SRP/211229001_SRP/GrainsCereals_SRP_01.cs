using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_SRP
{
    public class GrainsCereals_SRP_01 : Products_SRP_01
    {

        public GrainsCereals_SRP_01(int code, string ProductName, string category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }

        public GrainsCereals_SRP_01()
        {

        }

    } 
}
