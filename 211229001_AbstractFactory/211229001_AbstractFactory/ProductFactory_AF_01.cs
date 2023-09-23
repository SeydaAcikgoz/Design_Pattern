using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public class ProductFactory_AF_01 : IProductFactory_AF_01
    {
        Products_AF_01 product = new();
        public Beverages_AF_01 CreateBeverages(List<Products_AF_01> ProductsList)
        {
            Beverages_AF_01 beverages = new Beverages_AF_01(101, "Chai", 1, 39, 18);
            ProductsList.Add(beverages);
            Beverages_AF_01 beverages2 = new Beverages_AF_01(102, "Chang", 1, 17, 19);
            ProductsList.Add(beverages2);
            Beverages_AF_01 beverages3 = new Beverages_AF_01(103, "Guarana Fantastica", 1, 20, 4.5);
            ProductsList.Add(beverages3);
            return beverages;
        }

        public Confections_AF_01 CreateConfections(List<Products_AF_01> ProductsList)
        {
            Confections_AF_01 confections = new Confections_AF_01(201, "Konbu", 2, 24, 6);
            ProductsList.Add(confections);
            Confections_AF_01 confections2 = new Confections_AF_01(202, "Pavlova", 2, 29, 17.45);
            ProductsList.Add(confections2);
            Confections_AF_01 confections3 = new Confections_AF_01(203, "Sir Rodney's Marmalade", 2, 40, 81);
            ProductsList.Add(confections3);
            return confections;
        }

        public GrainsCereals_AF_01 CreateGrainsCereals(List<Products_AF_01> ProductsList)
        {
            GrainsCereals_AF_01 grainsCereals = new GrainsCereals_AF_01(301, "Ikura", 3, 31, 31);
            ProductsList.Add(grainsCereals);
            GrainsCereals_AF_01 grainsCereals2 = new GrainsCereals_AF_01(302, "Tofu", 3, 35, 25.25);
            ProductsList.Add(grainsCereals2);
            GrainsCereals_AF_01 grainsCereals3 = new GrainsCereals_AF_01(303, "Tunnbröd", 3, 61, 9);
            ProductsList.Add(grainsCereals3);

            return grainsCereals;
        }
    }
}
