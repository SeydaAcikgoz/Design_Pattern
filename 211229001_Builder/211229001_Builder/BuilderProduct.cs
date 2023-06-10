using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Builder
{
    public partial class Products_B_01
    {
        public class BuilderProduct
        {
            public int Code;
            public string ProductName;
            public string CategoryType;
            public int Stock;
            public double Price;

            public BuilderProduct() { }
            public BuilderProduct(int code, string ProductName, string category)
            {
                AddCode(code);
                AddName(ProductName);
                AddCategory(category);
            }

            public BuilderProduct AddCode(int code)
            {
                this.Code = code;
                return this;
            }

            public BuilderProduct AddName(string name)
            {
                this.ProductName = name;
                return this;
            }

            public BuilderProduct AddCategory(string category)
            {
                this.CategoryType = category;
                return this;
            }

            public BuilderProduct AddStock(int stock)
            {
                this.Stock = stock;
                return this;
            }

            public BuilderProduct AddPrice(double price)
            {
                this.Price = price;
                return this;
            }

            public Products_B_01 Build()
            {
                return new Products_B_01(this);
            }
        }
    }
}
