using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Composite1
{
    public class Ellipse : GraphicObject
    {

        public Ellipse(String name, String color) : base(name, color)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing an ellipse: " + name);
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing an ellipse: " + name);
        }

        public override void Paint()
        {
            Console.WriteLine("Painting an ellipse. : " + name + " and its color is " + color);
        }
    }
}
