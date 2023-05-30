using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public class EmployeeFactory_FM : IFactory
    {
        Random rnd = new Random();
        public Employee Create(string name)
        {
            Employee employee = new Employee(rnd.Next(10, 50), name, rnd.Next(2000, 2050), "dept1");
            return employee;
        }
    }
}
