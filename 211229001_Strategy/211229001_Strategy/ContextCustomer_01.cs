using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class ContextCustomer_01
    {
        private ICustomerCreate_01 bronz = new BronzCustomer_01();
        private ICustomerCreate_01 gold=new GoldCustomer_01();
        private ICustomerCreate_01 silver=new SilverCustomer_01();
        private ICustomerCreate_01 standard=new StandardCustomer_01() ;

        public Customer_01 CreateCustomer(int userno, string userName, string userSurname, string adress, double UserAmount, int point, int customerType, string email, string password, bool loginStatus)
        {
            Customer_01 customer = new Customer_01();
            if (customerType == 1)
            {
                customer = bronz.Create(userno, userName, userSurname, adress, UserAmount, point, email, password, loginStatus);
            }
            else if (customerType == 2)
            {
                customer = gold.Create(userno, userName, userSurname, adress, UserAmount, point, email, password, loginStatus);
            }
            else if (customerType == 3)
            {
                customer = silver.Create(userno, userName, userSurname, adress, UserAmount, point, email, password, loginStatus);
            }
            else if (customerType == 4)
            {
                customer = standard.Create(userno, userName, userSurname, adress, UserAmount, point, email, password, loginStatus);
            }
            return customer;

        }
    }
}
