using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Strategy
{
    public interface IProductCreate_01
    {
        public Products_01 Create(int code, string ProductName, int Stock, double Price);
    }
}
