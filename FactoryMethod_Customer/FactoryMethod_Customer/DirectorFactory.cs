using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public class DirectorFactory : IFactory
    {
        Random rnd = new Random();
        public Employee Create(string name)
        {
            Director employee = new Director(rnd.Next(10, 50), name, rnd.Next(2000, 2050), "dept1", "director dept 10", 1000);
            return employee;
        }
    }
}
