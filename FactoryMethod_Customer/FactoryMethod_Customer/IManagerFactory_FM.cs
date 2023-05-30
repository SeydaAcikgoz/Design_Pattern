using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public interface IManagerFactory_FM
    {
        public Manager Create(string name);
    }
}
