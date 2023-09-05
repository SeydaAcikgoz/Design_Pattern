using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_DIP
{
    public class BronzCustomer_DIP_01 : Customer_DIP_01
    {
        public BronzCustomer_DIP_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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
        
        public BronzCustomer_DIP_01()
        {
        }
        
        public double CalculatePrice(double total)
        {
            return total - (total * 5 / 100);
        }
    }         
}
