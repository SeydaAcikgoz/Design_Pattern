using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_ISP
{

    public class MSSQL_ISP : DB_Gorev1_ISP, DB_Gorev2_ISP
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
            Console.WriteLine(this.GetType().ToString() + " OtomatikSay");
        }

        public void Sil()
        {
            Console.WriteLine(this.GetType().ToString() + " Sil");
        }

        public void Sirala()
        {
            Console.WriteLine(this.GetType().ToString() + " Sirala");
        }
    }

    //ISP ye uygun değil
    public class MSSQL : DB
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
            Console.WriteLine(this.GetType().ToString() + " OtomatikSay");
        }

        public void Sil()
        {
            Console.WriteLine(this.GetType().ToString() + " Sil");
        }

        public void Sirala()
        {
            Console.WriteLine(this.GetType().ToString() + " Sirala");
        }
    }
}