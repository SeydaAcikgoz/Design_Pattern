using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public interface ITransactions2_01
    {
        public void Execute(int code, string ProductName, string category, int Stock, double Price, List<Products_01> ProductsList);
        public void Redo(int code, string ProductName, string category, int Stock, double Price, List<Products_01> ProductsList);
    }
}
