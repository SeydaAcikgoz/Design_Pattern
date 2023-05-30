using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Customer
{
    public interface IDirectorFactory_FM
    {
        public Director Create(string name, int bonus);
    }
}
