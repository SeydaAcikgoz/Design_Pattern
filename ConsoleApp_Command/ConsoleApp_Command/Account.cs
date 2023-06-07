using System;
using System.Collections.Generic;

namespace ConsoleApp_Command
{

    public class Account
    {

        private int balance;
        protected List<ITransaction> transactions;

        public Account(int balance)
        {
            this.balance = balance;
            transactions = new List<ITransaction>();
        }

        public int GetBalance()
        {
            return balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                throw new NotEnoughBalanceException(balance, amount);
        }


        public override String ToString()
        {
            return "Account [balance=" + balance + "]";
        }

        public void AddTransaction(ITransaction transaction)
        {
            transactions.Add(transaction);
        }

        public List<ITransaction> GetTransactions()
        {
            return transactions;
        }
    }
}
