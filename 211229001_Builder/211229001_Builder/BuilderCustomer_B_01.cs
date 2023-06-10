using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Builder
{
    public partial class Customer_B_01
    {
        public class BuilderCustomer_B_01
        {
            public int UserNo;
            public string UserName;
            public string UserSurname;
            public string Adress;
            public double UserAmount;
            public int Point;
            public string customerType;
            public string Email;
            public string Password;
            public bool LoginStatus;


            public BuilderCustomer_B_01(int userNo, string userName, string userSurname, int point, string customerType, string email, string password, bool loginStatus)
            {
                AddNo(userNo);
                AddName(userName);
                AddSurname(userSurname);
                AddPoint(point);
                AddType(customerType);
                AddEmail(email);
                AddPassword( password);
                AddStatus(loginStatus);
            }

            public BuilderCustomer_B_01 AddNo(int userNo)
            {
                this.UserNo = userNo;
                return this;
            }
            public BuilderCustomer_B_01 AddName(string userName)
            {
                this.UserName = userName;
                return this;
            }
            public BuilderCustomer_B_01 AddSurname(string userSurname)
            {
                this.UserSurname= userSurname;
                return this;
            }

            public BuilderCustomer_B_01 AddAdress(string adress)
            {
                this.Adress = adress;
                return this;
            }

            public BuilderCustomer_B_01 AddAmount(double userAmount)
            {
                this.UserAmount = userAmount;
                return this;
            }

            public BuilderCustomer_B_01 AddPoint(int point)
            {
                this.Point = point;
                return this;

            }


            public BuilderCustomer_B_01 AddType(string customerType)
            {
                this.customerType = customerType;
                return this;
            }

            public BuilderCustomer_B_01 AddEmail(string email)
            {
                this.Email = email;
                return this;
            }

            public BuilderCustomer_B_01 AddPassword(string password)
            {
                this.Password = password;
                return this;
            }

            public BuilderCustomer_B_01 AddStatus(bool loginStatus)
            {
                this.LoginStatus = loginStatus;
                return this;
            }



            public Customer_B_01 Build()
            {
                return new Customer_B_01(this);
            }
        }
    }
}
