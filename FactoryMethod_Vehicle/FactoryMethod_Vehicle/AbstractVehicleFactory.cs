using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Vehicle
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IArac AracOlustur(string aracTipi, string adi);
    }
}
