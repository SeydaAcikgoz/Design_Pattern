using System;

namespace ConsoleApp_LSP
{

    public class MYSQL_LSP : DB1_LSP
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
            throw new System.NotImplementedException();
        }

        public void Sil()
        {
            Console.WriteLine(this.GetType().ToString() + " Sil");
        }

        public void Sirala()
        {
            throw new System.NotImplementedException();
        }
    }


}