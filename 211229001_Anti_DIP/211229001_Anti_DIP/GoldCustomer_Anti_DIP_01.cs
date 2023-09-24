using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Anti_DIP
{
    public class GoldCustomer_Anti_DIP_01:Customer_Anti_DIP_01
    {
        public int discount = 15;
        public GoldCustomer_Anti_DIP_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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

        public GoldCustomer_Anti_DIP_01()
        {
        }
    }
}
