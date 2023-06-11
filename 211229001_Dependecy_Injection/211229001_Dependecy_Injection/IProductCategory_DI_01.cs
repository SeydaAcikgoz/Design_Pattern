using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public interface IProductCategory_DI_01
    {
        public Products_DI_01 Create(int code, string ProductName, string category, int Stock, double Price);
    }
}
