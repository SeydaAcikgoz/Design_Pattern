using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection_Engine
{
    public class Arac_DI : IArac
    {
        IMotor motor;

        public Arac_DI(IMotor motor)
        {
            this.motor = motor;
        }
        public void HareketEt()
        {
            this.motor.Baslat();
        }
    }
}
