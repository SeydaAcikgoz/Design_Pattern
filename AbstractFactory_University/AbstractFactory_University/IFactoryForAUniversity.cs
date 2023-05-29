using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public interface IFactoryForAUniversity
    {
        public Course CreateCourse();
        public Profesor CreateProfesor();
        public Schedule CreateSchedule();

    }
}
