using System;

namespace ConsoleApp_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            DB_TemelIslemler dB_TemelIslemler = new DB_TemelIslemler();
            dB_TemelIslemler.Baglan();

            Raporlama raporlama = new Raporlama();
            raporlama.RaporOlustur();
        }
    }
}