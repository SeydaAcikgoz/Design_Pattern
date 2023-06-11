using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Dependecy_Injection
{
    public interface IProduct_DI_01
    {
        public Beverages_DI_01 CreateBeverages(int code, string ProductName, string category, int Stock, double Price);

        public Confections_DI_01 CreateConfectionns(int code, string ProductName, string category, int Stock, double Price);
        public GrainsCereals_DI_01 CreateGrainsCereals(int code, string ProductName, string category, int Stock, double Price);
    }
}
