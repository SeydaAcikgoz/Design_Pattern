using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class CustomerTransactions_01
    {
        
        private ProductTransactions_01 productTransactions = new ProductTransactions_01();

        private bool login = false;

        public void LogIn(int cod, string email, string password, List<Customer_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");

        }
        
        public void LogInControl(string email, string password, Customer_01 customer)
        {

            if (customer.Email.Equals(email) && customer.Password.Equals(password))
            {
                customer.LoginStatus = true;
                login = true;
                Console.WriteLine("Successfully logged in.Wellcome " + customer.UserName);
                return;
            }
            else
            {
                Console.WriteLine("Email or Password wrong");
                return;
            }

        }

        public void IncreasePoints(Customer_01 customer, List<Products_01> basket)
        {
            customer.Point += basket.Count() * 10;
            Console.WriteLine("Current point:" + customer.Point);
        }
        
        public void Payment(Customer_01 customer, double total, List<Products_01> basket)
        {
            Console.WriteLine("Price:" + total);

            if (customer.customerType.Equals("Gold"))
            {
                total = total - (total * 15 / 100);
            }
            else if (customer.customerType.Equals("Silver"))
            {
                total = total - (total * 10 / 100);
            }
            else if (customer.customerType.Equals("Bronz"))
            {
                total = total - (total * 5 / 100);
            }
            Console.WriteLine("Price after discount applied:" + total);
            if (customer.UserAmount >= total)
            {
                customer.UserAmount -= total;
                Console.WriteLine("Payment has been made.Purchase completed");

            }
            else
            {
                Console.WriteLine("There is not enough balance");
            }
        }
        
        public void LogOut(int UserNo, List<Customer_01> CustomerList)
        {
            bool status = true;
            CustomerList.ForEach(delegate (Customer_01 customer)
            {
                if (customer.UserNo == UserNo)
                {
                    if (customer.LoginStatus == true)
                    {
                        customer.LoginStatus = false;
                        status = false;
                        Console.WriteLine("Successfully logged out");
                    }
                    else
                    {
                        Console.WriteLine("Already logged out");
                    }
                    return;
                }
            });
            if (status)
                Console.WriteLine("User not found!");
        }
        
        public void ShowAccount(int Usercode, List<Customer_01> CustomerList, List<Products_01> basket)
        {
            bool user = false;
            CustomerList.ForEach(delegate (Customer_01 customer)
            {
                if (customer.UserNo == Usercode)
                {
                    user = true;
                    Console.WriteLine(customer.UserName + "\t" + customer.UserSurname + "\t" + customer.Adress + "\t" + customer.Email + "\t" + customer.Password+"\t" + customer.LoginStatus+"\t"+customer.UserAmount);
                    Console.WriteLine("Your basket:");
                    productTransactions.ShowBasket(basket);
                }
            });
            if (!user)
                Console.WriteLine("User not found!");
        }
    }
}
