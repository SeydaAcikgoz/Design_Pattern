using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class Confections_01:Products_01
    {
        Confections_01 confections;
        public Confections_01(int code, string ProductName, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = "Confections";
            this.Stock = Stock;
            this.Price = Price;
        }

        public Confections_01()
        {

        }

        public Confections_01(List<Products_01> ProductsList)
        {
            confections = new Confections_01();
            confections.CreateConfections(ProductsList);
        }

        public Confections_01 CreateConfections(List<Products_01> ProductsList)
        {
            Confections_01 confections = new Confections_01(201, "Konbu", 24, 6);
            ProductsList.Add(confections);
            Confections_01 confections2 = new Confections_01(202, "Pavlova", 29, 17.45);
            ProductsList.Add(confections2);
            Confections_01 confections3 = new Confections_01(203, "Sir Rodney's Marmalade", 40, 81);
            ProductsList.Add(confections3);
            return confections;
        }
    }
}
