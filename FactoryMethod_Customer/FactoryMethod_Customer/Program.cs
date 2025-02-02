﻿using System;
using System.Collections.Generic;

namespace FactoryMethod_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Factory Method a uygun olmayan kısım
            
            IFactory managerFactory = new ManagerFactory();

            Employee manager1 = managerFactory.Create("Ali");
            Console.WriteLine(manager1.ToString());
            Employee manager2 = managerFactory.Create("Veli");
            Console.WriteLine(manager1.ToString());

            IFactory directorFactory = new DirectorFactory();

            Employee director1 = directorFactory.Create("Ayse");
            Console.WriteLine(director1.ToString());
            Employee director2 = directorFactory.Create("Fatma");
            Console.WriteLine(director2.ToString());
           */

            /*Factory Method a uygun olan kısım*/
            IDirectorFactory_FM directorFactory1 = new DirectorFactor_FM();
            Director director1 = directorFactory1.Create("Ali", 1000);
            Director director2 = directorFactory1.Create("Veli", 2500);

            IManagerFactory_FM managerFactory1 = new ManagerFactor_FM();
            Manager manager1 = managerFactory1.Create("Ayse");
            Manager manager2 = managerFactory1.Create("Fatma");

            List<Director> employees = new List<Director>() { director1, director2 };

            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString() + " dept: " + item.managingDepartment + "bonus: " + item.bonus);

            }
        }
    }
}
