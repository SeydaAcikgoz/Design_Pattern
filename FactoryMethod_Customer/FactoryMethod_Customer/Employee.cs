using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public class Employee
    {
        public int no { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public string department { get; set; }
        public double salary { get; set; }

        public static readonly int Base_salary = 9000;

        public Employee(int no, string name, int year, string department)
        {
            this.no = no;
            this.name = name;
            this.year = year;
            this.department = department;
        }

        public virtual void Work()
        {
            Console.WriteLine("Personel çalışıyor!");
        }

        public virtual double CalculateSalary()
        {
            salary = (year - 2000) * Base_salary;
            return salary;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("\n Personel Bilgi: ");
            builder.Append(" No: " + no);
            builder.Append(" Name:" + name);
            builder.Append(" Year: " + year);
            builder.Append(" Department: " + department);
            builder.Append(" Salary: " + CalculateSalary());
            return builder.ToString();
        }
    }
}
