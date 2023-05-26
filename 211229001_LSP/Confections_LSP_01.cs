using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_LSP
{
    public class Confections_LSP_01 : Products_LSP_01
    {


        public Confections_LSP_01(int code, string ProductName, int CategoryNo, string category, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryNo = CategoryNo;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
        }

        public Confections_LSP_01()
        {

        }
    }
}
