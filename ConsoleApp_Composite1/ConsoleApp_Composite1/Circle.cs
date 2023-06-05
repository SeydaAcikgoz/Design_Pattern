using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Composite1
{
    public class Circle : GraphicObject
    {
        public Circle(String name, String color) : base(name, color)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a cirle: " + name);
        }

        public override void Erase()
        {
            Console.WriteLine("Erasing a circle: " + name);
        }
        public override void Paint()
        {
            Console.WriteLine("Painting a circle. : " + name + " and its color is " + color);
        }

    }
}
