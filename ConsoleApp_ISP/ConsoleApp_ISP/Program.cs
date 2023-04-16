using System;

namespace ConsoleApp_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISP ye uygun değil
            MYSQL mYSQL = new MYSQL();
            mYSQL.OtomatikSay();
            mYSQL.Sirala();
            mYSQL.Baglan();

            MSSQL mSSQL = new MSSQL();//DB den de üretilse aynısı olur
            mSSQL.OtomatikSay();
            mSSQL.Sirala();

            //ISP ye uygun
            DB_Gorev1_ISP mSSQL_ISP = new MSSQL_ISP();
            mSSQL_ISP.Baglan();

            MYSQL_ISP mYSQL_ISP = new MYSQL_ISP();
            mYSQL_ISP.Baglan();
            mYSQL_ISP.Kaydet();






        }
    }
}