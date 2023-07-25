using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class BasketBuilder_01
    {
        Products_01 product = new Products_01();
        Customer_01 customer = new Customer_01();
        private CustomerTransactions_01 customerTransaction;
        private ProductTransactions_01 productTransaction ;

        public BasketBuilder_01()
        {
            customerTransaction = new CustomerTransactions_01();
            productTransaction = new ProductTransactions_01();
        }

        public void CreateBasket(int ProductCode, List<Products_01> ProductsList, List<Products_01> basket)
        {
            productTransaction.AddBasket(ProductCode, ProductsList, basket);
            productTransaction.ShowBasket(basket);
        }
    }
}
