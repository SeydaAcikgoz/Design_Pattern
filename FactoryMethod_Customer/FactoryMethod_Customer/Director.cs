using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public class Director : Manager
    {
        public double bonus { get; }
        public Director(int no, string name, int year, string workingDepartment, string managingDepartment, double bonus) : base(no, name, year, workingDepartment, managingDepartment)
        {
            this.bonus = bonus;
        }

        public override void Work()
        {
            // base.Work();
            Console.WriteLine("Director çalışıyor..");
        }

        public override void Manage()
        {
            Console.WriteLine("Director de YÖNETİR..");
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + bonus;
        }
    }
}
