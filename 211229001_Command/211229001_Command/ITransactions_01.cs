using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    internal interface ITransactions_01
    {
        public void Execute(int product, List<Products_01> basket);

        public void Undo(List<Products_01> basket);

        public void Redo(int product, List<Products_01> basket);
    }
}
