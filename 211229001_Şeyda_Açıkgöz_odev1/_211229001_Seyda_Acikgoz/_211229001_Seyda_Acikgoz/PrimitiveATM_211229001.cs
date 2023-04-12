using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Seyda_Acikgoz
{
    public class PrimitiveATM_211229001 
    {
        public bool login = true;
        public int amount = 1800;
        public bool passwordCorrect = true;

        public readonly int DAILY_AMOUNT = 500;

        public void logIn()
        {
            CalculatePassword();

            if (passwordCorrect)
            {
                login = true;
                Console.WriteLine("logged in");
            }

            else
                Console.WriteLine("Wrong password");

        }

        public void CalculatePassword()
        {
            passwordCorrect = true;
        }

        public void logOut()
        {
            if (login)
            {
                login = false;
                Console.WriteLine("logged out");
            }

            else
                Console.WriteLine("Already logged out");
        }

        public int GetAvailableMoney()
        {
            return amount;
        }

        public bool GetLogStatus()
        {
            return login;
        }

        public void Withdraw(int balance)
        {
            if (login)
            {
                if (balance < DAILY_AMOUNT)
                {
                    if (balance <= amount)
                    {
                        amount -= balance;
                        Console.WriteLine("Money successfully withdrawn.");
                        Console.WriteLine("Amount:" + amount);
                    }
                    else
                        Console.WriteLine("There is not that much money in the ATM.");
                }
                else
                    Console.WriteLine("The daily withdrawal amount has been exceeded.");
            }
            else
            {
                Console.WriteLine("Login failed!");
            }
        }


        public void Deposit(int balance)
        {
            if (login)
            {
                amount += balance;
                Console.WriteLine("Money deposited successfully");
                Console.WriteLine("Amount:" + amount);
            }
            else
            {
                Console.WriteLine("Login failed!");
            }
        }

        public void Act(int targetMoney)
        {

            if (targetMoney > 0)
            {
                int difference = amount - targetMoney;
                if (amount < targetMoney)
                {

                    difference = Math.Abs(difference);
                    Deposit(difference);
                }
                else
                {
                    difference = Math.Abs(difference);
                    Withdraw(difference);
                }
            }
            amount = targetMoney;
        }

    }
}

