using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Composite1
{
    public interface ICompositeGraphic
    {

        public void AddGraphic(IGraphic graphic);
        public void AddGraphics(List<IGraphic> graphics);

        public void RemoveGraphic(IGraphic graphic);

        public List<IGraphic> GetGraphics();

        public void ListGraphic();
    }
}
