using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class SilverCustomer_01 : Customer_01, ICustomerCreate_01, IMakeADiscount_01
    {
        public SilverCustomer_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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
            Customer_01 silver = new Customer_01();
            silver.UserNo = userno;
            silver.UserName = userName;
            silver.UserSurname = userSurname;
            silver.Adress = adress;
            silver.UserAmount = UserAmount;
            silver.Point = point;
            silver.customerType = "Silver";
            silver.Email = email;
            silver.Password = password;
            silver.LoginStatus = loginStatus;
            return silver;

        }

        public double CalculateDiscount(double total)
        {
            total = total - (total * 10 / 100);
            return total;
        }
        
        public SilverCustomer_01()
        {
        }
    
    }
}
