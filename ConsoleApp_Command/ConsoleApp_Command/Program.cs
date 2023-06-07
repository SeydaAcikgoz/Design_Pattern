using System;
using System.Collections.Generic;

namespace ConsoleApp_Command
{

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(10000);

            ITransaction transaction = new Withdraw();

            transaction.SetAccount(account);

            transaction.Execute(2000);
            Console.WriteLine(account);  
            transaction.Redo();
            Console.WriteLine(account);
            transaction.Redo();
            Console.WriteLine(account);

            Console.WriteLine(transaction);



            ITransaction transaction2 = new Deposit();
            transaction2.SetAccount(account);
            transaction2.Execute(500);
            Console.WriteLine(account);
            transaction2.Undo();
            Console.WriteLine(account);
            transaction2.Redo();
            Console.WriteLine(account);
            transaction2.Undo();
            Console.WriteLine(account);
            transaction2.Undo();
            Console.WriteLine(account);
            transaction2.Redo();
            Console.WriteLine(account);

            List<ITransaction> transactions = account.GetTransactions();
          
            foreach (ITransaction item in transactions)
                Console.WriteLine(item);

        }
    }
}
