using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Composite
{
    public class FactoryCustomer_01 : CustomerObject_01, ICompositeCustomer_01
    {
        public List<CustomerObject_01> CustomerList;
        public FactoryCustomer_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus) : base(userno, userName, userSurname, adress, UserAmount, point, customerType, email, password, loginStatus)
        {
            CustomerList = new List<CustomerObject_01>();
        }
        public void AddCustomers(CustomerObject_01 customer)
        {
            CustomerList.Add(customer);
        }


        public void ListCustomers()
        {

            Console.WriteLine("\nCustomer objects:");

            foreach (CustomerObject_01 customer in CustomerList)
            {
                Console.WriteLine(customer.UserNo + "\t" + customer.UserName + "\t" + customer.UserSurname + "\t" + customer.Adress + "\t" + customer.UserAmount
                    + "\t" + customer.Point + "\t" + customer.customerType +"\t" + customer.Email +"\t" + customer.Password+ "\t" + customer.LoginStatus);
            }
        }
    
    }
}
