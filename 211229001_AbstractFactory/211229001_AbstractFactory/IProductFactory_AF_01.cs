using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_AbstractFactory
{
    public interface IProductFactory_AF_01
    {
        public Beverages_AF_01 CreateBeverages(List<Products_AF_01> ProductsList);

        public Confections_AF_01 CreateConfections(List<Products_AF_01> ProductsList);

        public GrainsCereals_AF_01 CreateGrainsCereals(List<Products_AF_01> ProductsList);
    }
}
