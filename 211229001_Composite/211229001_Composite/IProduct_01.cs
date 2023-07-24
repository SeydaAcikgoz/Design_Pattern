using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Composite
{
    public interface IProduct_01
    {
        public void LogIn(int cod, string email, string password, List<CustomerObject_01> CustomerList);
        public void AddBasket(int USerCode, int ProductCode, List<ProductObject_01> ProductsList);
        public void ShowBasket();
        public void FindPrice(int ProductCode, List<ProductObject_01> ProductsList);
        public void FindStock(int ProductCode, List<ProductObject_01> ProductsList);
        public void ShowProductsCategory(string category, List<ProductObject_01> ProductsList);

    }
}
