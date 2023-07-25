using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class OrderTransactions_01
    {
        private CustomerTransactions_01 customerTransaction;
        private ProductTransactions_01 productTransaction;

        public OrderTransactions_01()
        {
            customerTransaction = new CustomerTransactions_01();
            productTransaction = new ProductTransactions_01();
        }
        public void Shipping(Customer_01 customer, List<Products_01> basket)
        {
            Console.WriteLine("Listed products have been shipped to the address " + customer.Adress);
            basket.Clear();
        }



        public void Buy(int UserCode, List<Products_01> ProductsList, List<Customer_01> CustomerList, List<Products_01> basket)
        {
            bool user = false;
            double total = 0;
            CustomerList.ForEach(delegate (Customer_01 customer)
            {
                if (customer.UserNo == UserCode)
                {
                    user = true;
                    if (customer.LoginStatus == true)
                    {
                        if (basket.Count > 0)
                        {
                            basket.ForEach(delegate (Products_01 product)
                            {
                                total += product.Price;
                            });
                        }
                        else
                        {
                            Console.WriteLine("Basket empty.");
                            return;
                        }
                        customerTransaction.IncreasePoints(customer, basket);
                        customerTransaction.Payment(customer, total, basket);

                    }
                    else
                    {
                        Console.WriteLine("Not logged in.Please loggin first.");
                        return;
                    }

                }
            });
            if (!user)
            {
                Console.WriteLine("User not found!");
            }
        }
    }
}
