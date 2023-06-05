namespace ConsoleApp_Composite1
{

    class Program
    {

        static void Main(string[] args)
        {
            //
            Canvas canvas = new Canvas("canvas1", "kırmızı");

            IGraphic graphic1 = new Circle("cir1", "sarı");
            IGraphic graphic2 = new Rectangle("rect1", "beyaz");
            IGraphic graphic3 = new Rectangle("rect2", "yesil");
            IGraphic graphic4 = new Ellipse("ellip2", "mor");

            List<IGraphic> graphicList = new List<IGraphic>() { graphic1, graphic2, graphic3, graphic4, graphic2 };

            canvas.AddGraphic(graphic1);
            canvas.AddGraphic(graphic2);
            canvas.AddGraphic(graphic3);
            canvas.AddGraphic(graphic4);
            canvas.AddGraphic(new Circle("cir1", "sarı")); //eğer oluşturulan nesneyi tutmaya gerek yoksa böyle de oluşturulabilir
            canvas.AddGraphics(graphicList);

            canvas.ListGraphic();
            canvas.Erase();
            canvas.Draw();

            canvas.RemoveGraphic(graphic4);
            canvas.ListGraphic();
            canvas.RemoveGraphic(graphic2);
            canvas.ListGraphic();
        }
    }
}
