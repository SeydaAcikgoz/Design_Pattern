using System;

namespace ConsoleApp_LSP
{
    class Program
    {
        /*
         LSP, üst ve alt sınıflar arasındaki ilişkileri (yani hiyerarşik ilişkileri) yönetir. 
         Size bir API'yi nasıl uygulayacağınızı söyler.

         ISP, üst ve istemci sınıflar arasındaki ilişkileri yönetir (yani üretici/tüketici ilişkileri). 
        Size bir API'yi ne zaman uygulayacağınızı söyler.
        */

        static void Main(string[] args)
        {
            DB dB = new MSSQL();
            dB.OtomatikSay();
            dB.Kaydet();

            dB = new MYSQL();
            //  dB.OtomatikSay();
            dB.Baglan();

            DB1_LSP dB1_LSP = new MYSQL_LSP();
            dB1_LSP.Kaydet();
            dB1_LSP.Baglan();

            DB1_LSP dB1_LSP1 = new MSSQL_LSP();
            dB1_LSP1.Baglan();

            DB2_LSP dB1_LSP2 = new MSSQL_LSP();
            dB1_LSP2.OtomatikSay();


        }
    }
}