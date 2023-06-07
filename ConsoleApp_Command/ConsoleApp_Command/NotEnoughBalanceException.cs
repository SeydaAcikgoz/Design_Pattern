using System;

namespace ConsoleApp_Command
{
    public class NotEnoughBalanceException : Exception
    {
        private static String description = "Hesapta yeterli bakiye yoktur: Miktar: ";

        public NotEnoughBalanceException(int balance, int amount) : base(description + balance + " Amount: " + amount)
        {

        }

    }
}
