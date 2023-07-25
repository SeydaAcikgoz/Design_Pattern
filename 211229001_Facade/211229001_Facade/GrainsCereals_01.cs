using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class GrainsCereals_01:Products_01
    {
        GrainsCereals_01 grainsCereals;
        public GrainsCereals_01(int code, string ProductName, int Stock, double Price)
        {
            this.Code = code;
            this.ProductName = ProductName;
            this.CategoryType = "GrainsCereals";
            this.Stock = Stock;
            this.Price = Price;
        }

        public GrainsCereals_01(List<Products_01> ProductsList)
        {
            grainsCereals = new GrainsCereals_01();
            grainsCereals.CreateGrainsCereals(ProductsList);
        }

        public GrainsCereals_01()
        {

        }


        public GrainsCereals_01 CreateGrainsCereals(List<Products_01> ProductsList)
        {
            GrainsCereals_01 grainsCereals = new GrainsCereals_01(301, "Ikura", 31, 31);
            ProductsList.Add(grainsCereals);
            GrainsCereals_01 grainsCereals2 = new GrainsCereals_01(302, "Tofu", 35, 25.25);
            ProductsList.Add(grainsCereals2);
            GrainsCereals_01 grainsCereals3 = new GrainsCereals_01(303, "Tunnbröd", 61, 9);
            ProductsList.Add(grainsCereals3);

            return grainsCereals;
        }
    }
}
