using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public class ManagerFactory : IFactory // IFactory
    {
        Random rnd = new Random();
        public Employee Create(string name)
        {
            Manager employee = new Manager(rnd.Next(10, 50), name, rnd.Next(2000, 2050), "dept1", "manage dept 10");
            return employee;
        }
    }
}
