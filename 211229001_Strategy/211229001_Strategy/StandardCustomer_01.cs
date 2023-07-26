using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class StandardCustomer_01:Customer_01, ICustomerCreate_01, IMakeADiscount_01
    {
        public StandardCustomer_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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
        public Customer_01 Create(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string email, string password, bool loginStatus)
        {
            Customer_01 standard = new Customer_01();
            standard.UserNo = userno;
            standard.UserName = userName;
            standard.UserSurname = userSurname;
            standard.Adress = adress;
            standard.UserAmount = UserAmount;
            standard.Point = point;
            standard.customerType = "Standard";
            standard.Email = email;
            standard.Password = password;
            standard.LoginStatus = loginStatus;
            return standard;

        }
        
        public double CalculateDiscount(double total)
        {
            return total;
        }
        
        public StandardCustomer_01()
        {
        }
    }
}
