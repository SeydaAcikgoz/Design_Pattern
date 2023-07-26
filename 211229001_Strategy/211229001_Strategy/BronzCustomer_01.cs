using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class BronzCustomer_01 : Customer_01, ICustomerCreate_01,IMakeADiscount_01
    {
        public BronzCustomer_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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
            Customer_01 bronz = new Customer_01();
            bronz.UserNo = userno;
            bronz.UserName = userName;
            bronz.UserSurname = userSurname;
            bronz.Adress = adress;
            bronz.UserAmount = UserAmount;
            bronz.Point = point;
            bronz.customerType = "Bronz";
            bronz.Email = email;
            bronz.Password = password;
            bronz.LoginStatus = loginStatus;
            return bronz;

        }

        public double CalculateDiscount( double total)
        {

            total = total - (total * 5 / 100);
            return total;
        }


        public BronzCustomer_01()
        {

        }

    }
}
