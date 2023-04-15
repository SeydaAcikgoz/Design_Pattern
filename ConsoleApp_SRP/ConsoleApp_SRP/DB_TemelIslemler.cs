using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SRP
{
    public class DB_TemelIslemler
    {
        public void Kaydet()
        {
            Console.WriteLine("kaydediliyor...");
        }
        public void Sil()
        {
            Console.WriteLine("Siliniyor...");
        }
        public void Baglan()
        {
            Console.WriteLine("Baglaniyor...");
        }
    }

    public class Raporlama
    {
        public void RaporOlustur()
        {
            Console.WriteLine("RaporOlusturuluyor...");
        }
        public void RaporYukle()
        {
            Console.WriteLine("RaporYukleniyor...");
        }

        public void RaporSil()
        {
            Console.WriteLine("RaporSiliniyor...");
        }
    }
}
