using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1
{
    public class Product
    {
        public List<object> list = new List<object>();

        public void Insert(string newItem)
        {
            this.list.Add(newItem);
        }

        public void ListParts()
        {

            string str = "";

            foreach (var item in list)
            {
                str = str + item.ToString() + "  \t";
            }

            Console.WriteLine("items: " + str);
        }
    }
}
