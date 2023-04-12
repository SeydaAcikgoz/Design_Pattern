using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Seyda_Acikgoz
{
    public enum BanknoteType
    {
        TEN=10, TWENTY = 20, FIFTY = 50, HUNDRED = 100
    }
   
    public class Banknote_211229001
    {
        private BanknoteType BanknoteType;
        public int Ten = 10, Twenty = 10, Fifty = 10, Hundred = 10;
        public void SetBanknote(BanknoteType banknoteType)
        {
            this.BanknoteType = banknoteType;
        }
        public BanknoteType GetBanknoteType()
        {
            return this.BanknoteType;
        }

        
    }
}