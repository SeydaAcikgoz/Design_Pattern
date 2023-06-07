using System;

namespace ConsoleApp_Command
{
    public class Withdraw : AbstractTransaction
    {
        public override void Execute(int amount)
        {
            this.amount = amount;

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

        public override void Undo()
        {
            account.Deposit(amount);
            account.AddTransaction(this);
        }
    }
}
