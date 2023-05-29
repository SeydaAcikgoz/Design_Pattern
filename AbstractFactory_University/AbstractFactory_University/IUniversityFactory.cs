using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_University
{
    public interface IUniversityFactory
    {
        Profesor CreateProfesor();
        Course CreateCourse();
        Schedule CreateSchedule();
    }
}
