using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjection_Engine
{
    public class _Arac
    {
        _BenzinMotor motor = new _BenzinMotor();

        public void HareketEt()
        {
            motor.Baslat();
        }
    }
}
