using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Composite1
{
    public class CanvasX:Canvas{    //aşağıdaki protected listeye böyle ulaşılabilir(listeye ulaşmka için yazılmıştır)
        public CanvasX(String name, String color) : base(name, color)
        {
            listOfGraphics = new List<IGraphic>();
        }
    }
    
    public class Canvas : GraphicObject, ICompositeGraphic
    {
    
        protected List<IGraphic> listOfGraphics;

        public Canvas(String name, String color) : base(name, color)
        {
            listOfGraphics = new List<IGraphic>();
        }

        public override void Draw()
        {
            Console.WriteLine("\nDrawing canvas: " + name);

            foreach (var item in listOfGraphics)
            {
                item.Draw();
            }

        }


        public override void Erase()
        {
            Console.WriteLine("\nErasing canvas: " + name);
            foreach (var graphic in listOfGraphics)
                graphic.Erase();
        }


        public override void Paint()
        {
            Console.WriteLine("\nPainting canvas: " + name + " and its color is " + color);

            foreach (IGraphic graphic in listOfGraphics)
                graphic.Paint();
        }


        public void AddGraphic(IGraphic graphic)
        {
            listOfGraphics.Add(graphic);
        }

        public void RemoveGraphic(IGraphic graphic)
        {
            listOfGraphics.Remove(graphic);
        }

        public List<IGraphic> GetGraphics()
        {
            return listOfGraphics;
        }

        public void ListGraphic()
        {
            Console.WriteLine("\nGraphic objects:");

            foreach (Object graphic in listOfGraphics)
            {
                Console.WriteLine(((IGraphic)graphic).ToString());
            }
        }

        public void AddGraphics(List<IGraphic> graphics)
        {
            this.listOfGraphics.Clear();
            listOfGraphics.AddRange(graphics);
        }
    }

}
