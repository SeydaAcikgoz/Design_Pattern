using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Composite1
{
    //bu class abstract olmayabilir.Eğer abstract olmayacaksa aşağıdaki metotlar virtual olarak yazılıp alt class larda override edilir.
    public abstract class GraphicObject : IGraphic  //doğrudan nesne oluşturmmamaıs için abstract yapıldı
    {
        protected String name;
        protected String color;

        public GraphicObject(String name, String color)
        {
            this.name = name;
            this.color = color;
        }


        public abstract void Draw();

        public abstract void Erase();

        public abstract void Paint();

        public override String ToString()
        {
            return "Graphic Object: " + name + " Color: " + color;
        }
    }
}
