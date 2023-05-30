using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public class Manager : Employee
    {
        private static readonly int Ekstra_Director_Payment = 50000;
        public string managingDepartment;
        public Manager(int no, string name, int year, string workingDepartment, string managingDepartment)
            : base(no, name, year, workingDepartment)
        {
            this.managingDepartment = managingDepartment;
        }

        public virtual void Manage()
        {
            Console.WriteLine("MANAGER yönetir..");
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + Ekstra_Director_Payment;
        }
    }
}
