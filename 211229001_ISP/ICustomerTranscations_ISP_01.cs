using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_ISP
{
    public interface ICustomerTranscations_ISP_01
    {
        public void LogOut(int UserNo, List<Customer_ISP_01> CustomerList);

        public void Buy(int UserCode, List<Products_ISP_01> ProductsList, List<Customer_ISP_01> CustomerList);

        public void Shipping(Customer_ISP_01 customer);
        public void ShowAccount(int Usercode, List<Customer_ISP_01> CustomerList);


    }
}
