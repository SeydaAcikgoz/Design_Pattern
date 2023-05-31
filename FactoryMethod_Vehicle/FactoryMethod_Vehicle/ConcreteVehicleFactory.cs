using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Vehicle
{
    public class VehicleFactory //: AbstractVehicleFactory
    {
        public  IArac AracOlustur(string aracTipi, string adi)
        {
            IArac factory = null;
            string ek = " abc";

            switch (aracTipi)
            {
                case "bisiklet":
                    factory = new Bisiklet_FM(adi + ek, 10);
                    break;
                case "tramvay":
                    factory = new Tramvay_FM(adi + ek, 60);
                    break;
                case "otomobil":
                    factory = new Otomobil_FM(adi + ek, 50);
                    break;
            }

            return factory;
        }
    }
    /* public class ConcreteVehicleFactory : AbstractVehicleFactory
    {
        public override IArac AracOlustur(string aracTipi, string adi)
        {
            IArac factory = null;
            string ek = " abc";

            switch (aracTipi)
            {
                case "bisiklet":
                    factory = new Bisiklet_FM(adi + ek, 10);
                    break;
                case "tramvay":
                    factory = new Tramvay_FM(adi + ek, 60);
                    break;
                case "otomobil":
                    factory = new Otomobil_FM(adi + ek, 50);
                    break;
            }

            return factory;
        }
    }
    bu şekilde de yazılabilir*/
}
