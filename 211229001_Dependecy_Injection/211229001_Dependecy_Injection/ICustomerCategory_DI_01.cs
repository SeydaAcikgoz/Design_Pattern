using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public interface ICustomerCategory_DI_01
    {
        public Customer_DI_01 Create(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus);
    }
}
