using AbstractFactory_University;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactory_University
{


    class Program
    {
        static void Main(string[] args)
        {
            /*Abstract Factory uygun olmayan kısım
            IUniversityFactory universityFactory = new AUniversityFactory();

             Course course = universityFactory.CreateCourse();
             universityFactory.CreateProfesor();
             Schedule schedule = universityFactory.CreateSchedule();
             Console.WriteLine("schedule.DersSayisiHesapla(): " + schedule.DersSayisiHesapla());


             BUniversityFactory universityFactory2 = new BUniversityFactory();
             List<Course> courses = universityFactory2.CreateCourses();
             Console.WriteLine(" courses.Sum(a => a.KrediHesapla())" + courses.Sum(x => x.KrediHesapla2()));
             Console.WriteLine("courses.Count: " + courses.Count);
            */

            // client ile..

            IUniversityFactory universityFactory = new BUniversityFactory();
            Client client = new Client(universityFactory);
            Console.WriteLine("client.course.KrediHesapla() " + client.course.KrediHesapla());



        }
    }
}
