using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Composite1
{
    public interface IGraphic
    {
        public void Draw();

        public void Erase();

        public void Paint();
    }
}
