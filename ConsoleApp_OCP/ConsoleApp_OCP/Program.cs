using System;

namespace ConsoleApp_OCP
{
    //farklı görevler için farklı bir interface üretiebilir
    public interface DB
    {
        public void Kaydet();
        public void Sil();
        public void Baglan();
    }
    //DIP ve OCP ye uygun değil
    public class Database
    {
        MySQL mysql;
        MSSQL mssql;
        Oracle oracle;

        public void Kaydet(string tip)
        {
            switch (tip) {
                case "mysql":
                    mysql = new MySQL();
                    Console.WriteLine("mysql kaydedildi.");
                    break;

                case "mssql":
                    mssql = new MSSQL();
                    Console.WriteLine("mssql kaydedildi."); 
                    break;

                case "oracle":
                    oracle = new Oracle();
                    Console.WriteLine("oracle kaydedildi.");
                    break;

                default: break;
            }
        }

        public void Sil(string tip)
        {
            switch (tip)
            {
                case "mysql":
                    mysql = new MySQL(); break;

                case "mssql":
                    mssql = new MSSQL(); break;

                default: break;
            }
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

        public void Sil()
        {
            Console.WriteLine(this.GetType().ToString() + " Sil");
        }
    }
    
    public class Oracle : DB
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

    public class MySQL : DB
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

    //DIP ve OCP ye uygun
    public class DBYoneticisi
    {
        private DB db;
        public DBYoneticisi(DB db)
        {
            this.db = db;
        }

        public void Baglan()
        {
            db.Baglan();
        }

        public void Kaydet()
        {
            db.Kaydet();
        }

        public void Sil()
        {
            db.Sil();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DB db = new MySQL();
            DBYoneticisi dBYoneticisi = new DBYoneticisi(db);
            dBYoneticisi.Baglan();
            dBYoneticisi.Kaydet();
            dBYoneticisi.Sil();

            DB db2 = new MSSQL();
            DBYoneticisi dBYoneticisi2 = new DBYoneticisi(db2);
            dBYoneticisi2.Baglan();
            dBYoneticisi2.Kaydet();
            dBYoneticisi2.Sil();
        }
    }
}