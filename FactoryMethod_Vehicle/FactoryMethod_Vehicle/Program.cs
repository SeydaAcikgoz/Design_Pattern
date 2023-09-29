using System;
using System.Collections.Generic;

namespace FactoryMethod_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Factory Method'a uygun olmayan kısım
            
            List<Arac> aracList = new List<Arac>();

             aracList.Add(new Bisiklet("my bike"));
             aracList.Add(new Otomobil("sahin"));
             aracList.Add(new Tramvay("skoda"));
             aracList.Add(new Tramvay("skoda2"));

             foreach (var item in aracList)
             {
                 item.HareketEt(50);
             }
            */

            //Factory Method'a uygun kısım
            VehicleFactory concreteVehicleFactory = new VehicleFactory();
            IArac factory1 = concreteVehicleFactory.AracOlustur("bisiklet", "bike 1");
            IArac factory2 = concreteVehicleFactory.AracOlustur("otomobil", "oto 1");
            IArac factory3 = concreteVehicleFactory.AracOlustur("bisiklet", "bike 2");
            IArac factory4 = concreteVehicleFactory.AracOlustur("tramvay", "skoda");

            List<IArac> factories = new List<IArac>() { factory1, factory2, factory3, factory4,
           concreteVehicleFactory.AracOlustur("tramvay", "sahin") };//sondki gibi de nesne oluşturulabilir

            foreach (var item in factories)
            {
                item.HareketEt(50);
                item.Dur();
            }
        }
    }
}
