using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public class Client
    {
        public Course course;
        public Profesor profesor;
        public Schedule schedule;
        public Client(IUniversityFactory universityFactory)
        {
            course = universityFactory.CreateCourse();
            profesor = universityFactory.CreateProfesor();
            schedule = universityFactory.CreateSchedule();
        }
    }
}
