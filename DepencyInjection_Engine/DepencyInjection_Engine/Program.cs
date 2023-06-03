using DepencyInjection_Engine;

namespace DependencyInjection_Engine
{



    class Program
    {
        static void Main(string[] args)
        {
            // _Arac arac = new _Arac();
            // arac.HareketEt();


            IMotor motor = new ElektrikMotor_DI();
            IArac arac1 = new Arac_DI(motor);
            arac1.HareketEt();


        }
    }
}
