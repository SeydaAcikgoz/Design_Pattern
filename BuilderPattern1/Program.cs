using BuilderPattern1;
using System;
using System.Linq;

namespace BuilderPattern1
{

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();//ConcreteBuilder builder = new ConcreteBuilder(); ya da Ibuilder builder = new ConcreteBuilder(); da yazılabilir
            var director = new Director(builder);

            Console.WriteLine("Minimal  ürün:");
            director.BuildMinimalProduct();

            builder.GetProduct().ListParts();

            Console.WriteLine("Tüm özelliklere sahip ürün:");
            director.BuildFullFeaturedProduct();
            builder.GetProduct().ListParts();

            Console.WriteLine("Özel üretim olsun:");
            builder.BuildPartA();
            builder.BuildPartC();
            builder.GetProduct().ListParts();
        }
    }
}
