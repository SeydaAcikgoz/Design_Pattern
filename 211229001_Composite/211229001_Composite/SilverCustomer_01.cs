﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Composite
{
    public class SilverCustomer_01 : CustomerObject_01
    {
        public SilverCustomer_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus) : base(userno, userName, userSurname, adress, UserAmount, point, customerType, email, password, loginStatus)
        {
        }
    }
}
