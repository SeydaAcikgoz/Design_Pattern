using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public abstract class AbstractTransactions_01:ITransactions_01
    {
        protected Products_01 product=new Products_01();
        public int Code;
        public string ProductName;
        public string CategoryType;
        public int Stock;
        public double Price;

        public AbstractTransactions_01()
        {
            Console.WriteLine("İşlem Tipi: " + this.GetType());
        }

        public void Redo(int product, List<Products_01> basket)
        {
            Execute(product, basket);
        }

        public abstract void Execute(int product, List<Products_01> basket);

        public abstract void Undo( List<Products_01> basket);

    }
}
