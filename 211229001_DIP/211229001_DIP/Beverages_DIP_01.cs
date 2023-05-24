using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_DIP
{
    public class Beverages_DIP_01 : Products_DIP_01
    {
        public Beverages_DIP_01(int code, string ProductName, int CategoryNo, string category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryNo = CategoryNo;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }
        public Beverages_DIP_01()
        {

        }

      
    }
}
