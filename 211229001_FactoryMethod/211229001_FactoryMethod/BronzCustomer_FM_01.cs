using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_FactoryMethod
{
    public class BronzCustomer_FM_01:Customer_FM_01, IBronzCustomerFactory_FM_01
    {
        public BronzCustomer_FM_01()
        {

        }
        public BronzCustomer_FM_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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

        public BronzCustomer_FM_01 Create(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
        {
            BronzCustomer_FM_01 bronzCustomer = new BronzCustomer_FM_01(userno, userName, userSurname, adress, UserAmount, point, customerType, email, password, loginStatus);
            return bronzCustomer;
        }
    }
}
