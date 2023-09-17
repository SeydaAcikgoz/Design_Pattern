using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Command
{
    public class NotEnoughAmountException_01:Exception
    {
        private static String description = "Not enough products ";

        public NotEnoughAmountException_01() : base(description)
        {
        }
    }
}
