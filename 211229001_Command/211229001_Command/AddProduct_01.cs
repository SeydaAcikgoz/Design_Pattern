using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public class AddProduct_01 : AbstractTransactions2_01
    {
        public override void Execute(int code, string ProductName, string category, int Stock, double Price, List<Products_01> ProductsList)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = category;
            this.Stock = Stock;
            this.Price = Price;
            this.Code = Code;
            product.Create(code, ProductName, category, Stock, Price,ProductsList);
        }

        
    }
}
