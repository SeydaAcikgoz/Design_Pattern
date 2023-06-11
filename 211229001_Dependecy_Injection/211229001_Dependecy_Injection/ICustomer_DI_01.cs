using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public interface ICustomer_DI_01
    {
        public BronzCustomer_DI_01 CreateBronzCustomer(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus);

        public GoldCustomer_01 CreateGoldzCustomer(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus);

        public SilverCustomer_DI_01 CreateSilverCustomer(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus);

        public StandardCustomer_DI_01 CreateStandardCustomer(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus);
    }
}
