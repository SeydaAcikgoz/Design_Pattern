using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_FactoryMethod
{
    public interface IGrainsCerealsFactory_FM_01
    {
        public GrainsCereals_FM_01 Create(int code, string ProductName, int category, int Stock, double Price);
    }
}
