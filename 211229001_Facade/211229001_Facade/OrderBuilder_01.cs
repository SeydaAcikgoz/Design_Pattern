using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Facade
{
    public class OrderBuilder_01
    {
        private CustomerTransactions_01 customerTransaction;
        private ProductTransactions_01 productTransaction;
        private OrderTransactions_01 orderTransaction;


        public OrderBuilder_01()
        {
        }
        public OrderBuilder_01(int UserCode, List<Products_01> ProductsList, List<Customer_01> CustomerList, List<Products_01> basket, Customer_01 customer)
        {
            customerTransaction = new CustomerTransactions_01();
            productTransaction = new ProductTransactions_01();
            orderTransaction = new OrderTransactions_01();
            CreateOrder(UserCode,ProductsList,CustomerList,basket,customer);
        }

        public void CreateOrder(int UserCode, List<Products_01> ProductsList, List<Customer_01> CustomerList, List<Products_01> basket, Customer_01 customer)
        {
            orderTransaction.Buy(UserCode, ProductsList, CustomerList, basket);
            productTransaction.ShowBasket(basket);
            orderTransaction.Shipping(customer, basket);

        }


    }
}

