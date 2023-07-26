using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public interface ICustomerCreate_01
    {
        public Customer_01 Create(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string email, string password, bool loginStatus);
    }
}
