using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public class Buy_01:AbstractTransactions_01
    {
        public override void Execute(int Code, List<Products_01> basket)
        {
            this.Code = Code;
            product.Buy(Code, basket);
        }

        public override void Undo( List<Products_01> basket)
        {
            try
            {
                product.Return(Code, basket);
            }
            catch (NotEnoughAmountException_01 e)
            {
                Console.WriteLine("Can't withdraw: " + e.Message);
            }

        }

    }
}
