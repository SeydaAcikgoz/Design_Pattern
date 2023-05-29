using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public class BUniversityFactory : IUniversityFactory //IFactoryForBUniversity
    {
        public List<Course> CreateCourses()
        {
            List<Course> courseList = new List<Course>();

            for (int i = 0; i < 10; i++)
            {
                courseList.Add(CreateCourse());
            }

            return courseList;
        }
        public Course CreateCourse()
        {
            Course course = new Course(5);
            return course;
        }

        public Profesor CreateProfesor()
        {
            Profesor profesor = new Profesor();
            return profesor;
        }

        public Schedule CreateSchedule()
        {
            Schedule schedule = new Schedule(20);
            return schedule;
        }
    }
}
