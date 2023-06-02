using BuilderPattern2;
using System;

namespace BuilderPattern2
{

    class Program
    {
        static void Main(string[] args)
        {

            /* Builder Pattern a uygun olmayan kısım
               Musteri.Builder builder1 = new Musteri.Builder("ahmet", "celebi");
               Musteri musteri3 = builder1.MaasEkle((decimal)12000.45).YasEkle(20).Build();



               Musteri musteri2 = new Musteri.Builder("ALİ", "YILMAZ").MaasEkle((decimal)15500.45).YasEkle(49).Build();
               Musteri musteri = new Musteri.Builder("ALİ", "YILMAZ").Build();

               Console.WriteLine(musteri.ToString());*/

            //Builder Pattern a uygun olmayan kısım
            Musteri.Builder builder = new Musteri.Builder("ALİ", "YILMAZ");

            Console.WriteLine("musteri yasi giriniz: ");

            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas > 0)
            {
                builder.YasEkle(yas);
            }

            Console.WriteLine("musteri MAASI giriniz: ");

            decimal maas = Convert.ToDecimal(Console.ReadLine()); // (decimal)12000.54;

            if (maas > 0)
            {
                builder = builder.MaasEkle(maas);
            }

            Musteri musteri1 = builder.Build();

            Console.WriteLine(musteri1);



        }
    }
}
