using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            this._builder = builder;
        }

        public void BuildMinimalProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();

        }

        public void BuildFullFeaturedProduct1()
        {
            this._builder.BuildPartC();
            this._builder.BuildPartA();
            this._builder.BuildPartB();
        }
    }
}
