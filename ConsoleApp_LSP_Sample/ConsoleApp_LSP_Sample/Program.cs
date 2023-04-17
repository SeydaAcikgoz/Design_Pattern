using System;

namespace ConsoleApp_LSP_Sample
{

    public class Rectangle
    {
        int shortSide, longSide;

        public long CalculateArea()
        {
            return shortSide * longSide;
        }


        public virtual void setWidth(int shortSide)
        {
            this.shortSide = shortSide;
        }

        public virtual void setHeight(int longSide)
        {
            this.longSide = longSide;
        }


    }

    public class Square : Rectangle
    {

        override public void setWidth(int width)
        {
            base.setHeight(width);
            base.setWidth(width);

        }

        override public void setHeight(int height)
        {
            base.setHeight(height);
            base.setWidth(height);
        }

    }
    //LSP start
    public interface Shape
    {
        long CalculateArea();
    }

    public class Square_LSP : Shape
    {
        int size;

        public Square_LSP(int size)
        {
            this.size = size;
        }
        public long CalculateArea()
        {
            return size * size;
        }



    }


    public class Rectangle_LSP : Shape
    {
        private int width;
        private int height;
        public Rectangle_LSP(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public long CalculateArea()
        {
            return width * height;
        }
        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
    }
    //LSP end


    class Program
    {
        static void Main(string[] args)
        {
            //Square square = new Square();     böyle yaparsak lsp ye uygun olmaz
            Rectangle square = new Square();

            square.setHeight(20);
            square.setWidth(10);

            Console.WriteLine("square.CalculateArea(): 200? " + square.CalculateArea()); // Assert.equal
            //LSP uygun değil


            Shape shape = new Rectangle_LSP(20, 50);
            Console.WriteLine("shape.CalculateArea(): 1000? " + shape.CalculateArea()); // Assert.equal
            Rectangle_LSP rec = new Rectangle_LSP(20, 50);
            Console.WriteLine("shape.CalculateArea(): 1000? " + rec.CalculateArea()); // yukarıdaki ile aynı sonuç

            Shape shape2 = new Square_LSP(20);
            Console.WriteLine("shape.CalculateArea(): 400? " + shape2.CalculateArea()); // Assert.equal
            //LSP uygun
        }
    }
}