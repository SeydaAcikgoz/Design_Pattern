using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class ContextProduct_01
    {
        private IProductCreate_01 beverages = new Beverages_01();
        private IProductCreate_01 confections = new Confections_01();
        private IProductCreate_01 grainsCereals = new GrainsCereals_01();

        public Products_01 CreateProduct(int code, string ProductName, int category, int Stock, double Price)
        {
            Products_01 products = new Products_01();
            if(category == 1) {
                products=beverages.Create(code, ProductName, Stock, Price);
            }
            else if (category == 2)
            {
                products=confections.Create(code, ProductName, Stock, Price);
            }
            else if (category == 3)
            {
                products=grainsCereals.Create(code, ProductName, Stock, Price);
            }
            return products;
        }
    }
}
