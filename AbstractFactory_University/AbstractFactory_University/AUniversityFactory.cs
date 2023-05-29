using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public class AUniversityFactory : IUniversityFactory //IFactoryForAUniversity
    {
        public Course CreateCourse()
        {
            Course course = new Course(30);
            return course;
        }

        public Profesor CreateProfesor()
        {
            Profesor profesor = new Profesor();
            return profesor;
        }

        public Schedule CreateSchedule()
        {
            Schedule schedule = new Schedule(10);
            return schedule;
        }

    }
}
