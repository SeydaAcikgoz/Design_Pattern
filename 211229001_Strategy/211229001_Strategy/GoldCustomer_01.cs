using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public class GoldCustomer_01 : Customer_01, ICustomerCreate_01, IMakeADiscount_01
    {
        public GoldCustomer_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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
            Customer_01 gold = new Customer_01();
            gold.UserNo = userno;
            gold.UserName = userName;
            gold.UserSurname = userSurname;
            gold.Adress = adress;
            gold.UserAmount = UserAmount;
            gold.Point = point;
            gold.customerType = "Gold";
            gold.Email = email;
            gold.Password = password;
            gold.LoginStatus = loginStatus;
            return gold;

        }

        public double CalculateDiscount(double total)
        {

            total = total - (total * 15 / 100);
            return total;
        }
        public GoldCustomer_01()
        {

        }
    
    }
}
