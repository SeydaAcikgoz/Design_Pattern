using System;

namespace ConsoleApp_ISP
{

    public class MYSQL_ISP : DB_Gorev1_ISP
    {
        public void Baglan()
        {
            Console.WriteLine(this.GetType().ToString() + " Baglan");
        }

        public void Kaydet()
        {
            Console.WriteLine(this.GetType().ToString() + " Kaydet");
        }


        public void Sil()
        {
            Console.WriteLine(this.GetType().ToString() + " Sil");
        }
    }

    public class MYSQL : DB
    {
        public void Baglan()
        {
            Console.WriteLine(this.GetType().ToString() + " Baglan");
        }

        public void Kaydet()
        {
            Console.WriteLine(this.GetType().ToString() + " Kaydet");
        }

        public void OtomatikSay()
        {
            Console.WriteLine("calismiyor");
        }

        public void Sil()
        {
            Console.WriteLine(this.GetType().ToString() + " Sil");
        }

        public void Sirala()
        {
            Console.WriteLine("yok");
        }
    }


}