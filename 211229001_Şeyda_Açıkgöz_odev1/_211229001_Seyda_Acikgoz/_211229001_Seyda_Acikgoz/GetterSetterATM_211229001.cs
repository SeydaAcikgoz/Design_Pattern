using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Seyda_Acikgoz
{
    public class GetterSetterATM_211229001
    {
        public bool login { get; set; } = false;
        public int amount { get; set; } = 1800;
        public bool passwordCorrect { get; set; } = true;
        public readonly int DAILY_AMOUNT = 500;
    }
}
