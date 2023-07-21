using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public abstract class AbstractTransactions2_01:ITransactions2_01
    {
        protected Products_01 product = new Products_01();
        public int Code;
        public string ProductName;
        public string CategoryType;
        public int Stock;
        public double Price;

        public AbstractTransactions2_01()
        {
            Console.WriteLine("İşlem Tipi: " + this.GetType());
        }

        public void Redo(int code, string ProductName, string category, int Stock, double Price, List<Products_01> ProductsList)
        {
            Execute( code,  ProductName,  category,  Stock,  Price, ProductsList);
        }

        public abstract void Execute(int code, string ProductName, string category, int Stock, double Price, List<Products_01> ProductsList);


    }
}
