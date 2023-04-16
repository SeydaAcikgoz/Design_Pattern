using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_LSP
{

    public class MSSQL_LSP : DB1_LSP, DB2_LSP
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