using System.Drawing;

namespace _211229001_Seyda_Acikgoz
{
    class Program_211229001
    {

        static void RunEncapsulatedATM()
        {
            EncapsulatedATM_211229001 atm = new EncapsulatedATM_211229001();
            atm.logOut();
            atm.Deposit(210);
            atm.Withdraw(500);
            atm.Withdraw(200);
            atm.Act(2000);
            atm.Deposit(10);
            atm.Withdraw(2000);
            atm.Deposit(2200);
            atm.Withdraw(100);
            atm.Deposit(10);
            atm.Deposit(100);
            atm.Withdraw(200);
            atm.Act(2000);
            atm.Act(2400);
            atm.logOut();
        }

        static void RunPrimitiveATM()
        {
            PrimitiveATM_211229001 atm = new PrimitiveATM_211229001();
            atm.logIn();
            atm.Deposit(210);
            atm.Withdraw(500);
            atm.Withdraw(200);
            atm.Act(2000);
            atm.Deposit(10);
            atm.Withdraw(2000);
            atm.logOut();
            atm.logIn();
            atm.Deposit(2200);
            atm.Withdraw(100);
            atm.Deposit(10);
            atm.Deposit(100);
            atm.Withdraw(200);
            atm.Act(2000);
            atm.Act(2400);
            atm.logOut();
            atm.logIn();
        }


        static void RunGetterSetterATM()
        {
            GetterSetterATM_211229001 atm = new GetterSetterATM_211229001();
            atm.passwordCorrect = true;
            atm.login = true;
            atm.amount -= 100;
            atm.amount += 400;
            atm.amount = -20;
            atm.login = false;
            atm.amount = 1000;
            atm.amount = -100;
            atm.login = false;
        }

        static void RunDataOnlyATM()
        {
            DataOnlyATM_211229001 atm = new DataOnlyATM_211229001();
            atm.passwordCorrect = true;
            atm.login = true;
            atm.amount -= 100;
            atm.amount += 400;
            atm.amount = -100;
            atm.login = false;
            atm.passwordCorrect = true;
            atm.login = true;
            atm.amount = 1000;
            atm.amount = -5000;
            atm.login = false;
        }
        public static void Main(String[] args)
        {
            //RunDataOnlyATM();
            //RunGetterSetterATM();
            //RunPrimitiveATM();
            RunEncapsulatedATM();
        }
    }
}
