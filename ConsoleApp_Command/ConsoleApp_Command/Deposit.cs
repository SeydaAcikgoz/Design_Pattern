using System;

namespace ConsoleApp_Command
{
    public class Deposit : AbstractTransaction
    {
        public override void Execute(int amount)
        {
            this.amount = amount;
            account.Deposit(amount);
            account.AddTransaction(this);
        }

        public override void Undo()
        {
            try
            {
                account.Withdraw(amount);
            }
            catch (NotEnoughBalanceException e)
            {
                Console.WriteLine("Can't withdraw: " + e.Message);
            }

            account.AddTransaction(this);
        }
    }
}
