using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class Beverages_01:Products_01
    {
        Beverages_01 beverages;
        public Beverages_01(int code, string ProductName, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = "Beverages";
            this.Stock = Stock;
            this.Price = Price;
        }
        public Beverages_01()
        {
        }


        public Beverages_01(List<Products_01> ProductsList)
        {
            beverages = new Beverages_01 ();
            beverages.CreateBeverages(ProductsList);
        }


        public Beverages_01 CreateBeverages(List<Products_01> ProductsList)
        {
            Beverages_01 beverages = new Beverages_01(101, "Chai", 39, 18);
            ProductsList.Add(beverages);
            Beverages_01 beverages2 = new Beverages_01(102, "Chang", 17, 19);
            ProductsList.Add(beverages2);
            Beverages_01 beverages3 = new Beverages_01(103, "Guarana Fantastica", 20, 4.5);
            ProductsList.Add(beverages3);

            return beverages;
        }
    }
}
