using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public void Reset()
        {
            product = new Product();
        }
        public void BuildPartA()
        {
            this.product.Insert("PartA1");
        }

        public void BuildPartB()
        {
            this.product.Insert("PartB1");
        }

        public void BuildPartC()
        {
            this.product.Insert("PartC1");
        }
        public Product GetProduct()
        {
            Product result = this.product;

            this.Reset();

            return result;
        }
    }
}
