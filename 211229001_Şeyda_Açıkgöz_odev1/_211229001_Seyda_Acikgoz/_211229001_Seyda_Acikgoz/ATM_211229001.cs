using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Seyda_Acikgoz
{
    public interface ATM_211229001
    {
        public void Act(int targetMoney);
        public void Withdraw(int balance);
        public void Deposit(int balance);
        public void AfterAct(int balance);
    }
}
