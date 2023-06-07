using System;
using System.Collections.Generic;

namespace ConsoleApp_Command
{
    public abstract class AbstractTransaction : ITransaction
    {

        protected Account account;
        protected int amount;

        public AbstractTransaction()
        {
            Console.WriteLine("İşlem Tipi: " + this.GetType());
        }


        public void Redo()
        {
            Execute(amount);
        }

        public List<ITransaction> GetTransactions()
        {
            return account.GetTransactions();
        }

        public void SetAccount(Account account)
        {
            this.account = account;
        }

        public override String ToString()
        {
            return this.GetType() + " [account=" + account + ", amount=" + amount + "]";
        }

        public abstract void Execute(int amount);


        public abstract void Undo();


    }
}
