using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public class SilverCustomer_DI_01 : Customer_DI_01,ICustomerCategory_DI_01
    {
        public SilverCustomer_DI_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
        {
            this.UserNo = userno;
            this.UserName = userName;
            this.UserSurname = userSurname;
            this.Adress = adress;
            this.UserAmount = UserAmount;
            this.Point = point;
            this.customerType = customerType;
            this.Email = email;
            this.Password = password;
            this.LoginStatus = loginStatus;
        }

        public SilverCustomer_DI_01()
        {

        }
        public Customer_DI_01 Create(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
        {
            Customer_DI_01 customer = new Customer_DI_01(userno, userName, userSurname, adress, UserAmount, point, customerType, email, password, loginStatus);
            return customer;
        }
    }
}
