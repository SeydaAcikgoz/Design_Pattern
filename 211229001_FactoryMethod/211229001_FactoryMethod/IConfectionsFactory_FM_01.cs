using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_FactoryMethod
{
    public interface IConfectionsFactory_FM_01
    {
        public Confections_FM_01 Create(int code, string ProductName, int category, int Stock, double Price);
    }
}
