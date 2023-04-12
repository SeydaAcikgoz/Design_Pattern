using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Seyda_Acikgoz
{
    public class EncapsulatedATM_211229001 : ATM_211229001
    {
        public bool login = true;
        public int amount = 1800;
        public bool passwordCorrect = true;

        public readonly int DAILY_AMOUNT = 500;

        BanknoteType BanknoteType = new BanknoteType();
       
        Banknote_211229001 banknote = new Banknote_211229001();

        
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
            return this.amount;
        }

        public bool GetLogStatus()
        {
            return login;
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
                    AfterAct(targetMoney);
                }
                else
                {
                    difference = Math.Abs(difference);
                    Withdraw(difference);
                    AfterAct(targetMoney);

                   
                }
                amount = targetMoney;
            }
        }

        public void Deposit(int balance)
        {
            if (!login)
                logIn();
            
                amount += balance;
                while (balance >= (int)BanknoteType.HUNDRED)
                {
                    balance -= (int)BanknoteType.HUNDRED;
                    banknote.Hundred++;
                }

                while (balance >= (int)BanknoteType.FIFTY)
                {
                    balance -= (int)BanknoteType.FIFTY;
                    banknote.Fifty++;
                }

                while (balance >= (int)BanknoteType.TWENTY)
                {
                    balance -= (int)BanknoteType.TWENTY;
                    banknote.Twenty++;
                }

                while (balance >= (int)BanknoteType.TEN)
                {
                    balance -= (int)BanknoteType.TEN;
                    banknote.Ten++;
                }
                Console.WriteLine("Money deposited successfully");
                Console.WriteLine("Amount:" + amount);

        }

        public void Withdraw(int balance)
        {
            if (!login)
                logIn();

            if (balance < DAILY_AMOUNT)
            {
                if (balance <= amount)
                {
                    amount -= balance;
                    while (balance >= (int)BanknoteType.HUNDRED)
                    {
                        if (BanknoteType.HUNDRED <= 0)
                        {
                            Console.WriteLine("The transaction did not take place because there is no valid banknote");
                            return;

                        }
                        balance -= (int)BanknoteType.HUNDRED;
                        banknote.Hundred--;
                    }

                    while (balance >= (int)BanknoteType.FIFTY)
                    {
                        if (BanknoteType.FIFTY <= 0)
                        {
                            Console.WriteLine("The transaction did not take place because there is no valid banknote");
                            return;

                        }
                        balance -= (int)BanknoteType.FIFTY;
                        banknote.Fifty--;
                    }

                    while (balance >= (int)BanknoteType.TWENTY)
                    {
                        if (BanknoteType.TWENTY <= 0)
                        {
                            Console.WriteLine("The transaction did not take place because there is no valid banknote");
                            return;

                        }
                        balance -= (int)BanknoteType.TWENTY;
                        banknote.Twenty--;
                    }

                    while (balance >= (int)BanknoteType.TEN)
                    {
                        if (BanknoteType.TEN <= 0)
                        {
                            Console.WriteLine("The transaction did not take place because there is no valid banknote");
                            return;

                        }
                        balance -= (int)BanknoteType.TEN;
                        banknote.Ten--;
                    }
                    Console.WriteLine("Money successfully withdrawn.");
                    Console.WriteLine("Amount:" + amount);
                }
                else
                    Console.WriteLine("There is not that much money in the ATM.");
            }
            else
                Console.WriteLine("The daily withdrawal amount has been exceeded.");
        }

        public void AfterAct(int balance)
        {
            banknote.Hundred = 0;
            banknote.Fifty = 0;
            banknote.Twenty = 0;
            banknote.Ten = 0;
            while (balance >= (int)BanknoteType.HUNDRED)
            {
                balance -= (int)BanknoteType.HUNDRED;
                banknote.Hundred++;
            }

            while (balance >= (int)BanknoteType.FIFTY)
            {
                balance -= (int)BanknoteType.FIFTY;
                banknote.Fifty++;
            }

            while (balance >= (int)BanknoteType.TWENTY)
            {
                balance -= (int)BanknoteType.TWENTY;
                banknote.Twenty++;
            }

            while (balance >= (int)BanknoteType.TEN)
            {
                balance -= (int)BanknoteType.TEN;
                banknote.Ten++;
            }

        }

    }

}
