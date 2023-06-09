using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public class ClientProduct_AF_01
    {
        public Beverages_AF_01 beverages;
        public Confections_AF_01 confections;
        public GrainsCereals_AF_01 grainsCereals;

        public ClientProduct_AF_01(IProductFactory_AF_01 productFactory,List<Products_AF_01> ProductsList)
        {
            beverages = productFactory.CreateBeverages(ProductsList);
            confections = productFactory.CreateConfections(ProductsList);
            grainsCereals = productFactory.CreateGrainsCereals(ProductsList);
        }

    }
}
