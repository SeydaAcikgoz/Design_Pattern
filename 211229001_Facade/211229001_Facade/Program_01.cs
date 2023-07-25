using System.Collections.Generic;

namespace _211229001_Facade
{

    class Program
    {
        static void Main(string[] args)
        {


            List<Customer_01> CustomerList = new List<Customer_01>();
            List<Products_01> ProductsList = new List<Products_01>();
            List<Products_01> basket = new List<Products_01>();

            CustomerTransactions_01 customerTransactions = new CustomerTransactions_01();
            ProductTransactions_01 productTransactions = new ProductTransactions_01();
            
            BasketBuilder_01 basketBuilder = new BasketBuilder_01();

            ProductsBuilder_01 builder = new ProductsBuilder_01();
            productTransactions.CreateProductList(ProductsList);//listenin oluşturulduğu yer


            Customer_01 customer = new Customer_01();
            Products_01 product = new Products_01();
            CustomerList.Add(new BronzCustomer_01() { UserNo = 1, UserName = "Seyda", UserSurname = "Acikgoz", Adress = "Konya", UserAmount = 1230, Point = 15, customerType = "Bronz", Email = "seyda@gmail.com", Password = "123Seyda", LoginStatus = false });



            customerTransactions.LogIn(5, "seyda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            customerTransactions.LogIn(1, "seda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            customerTransactions.LogIn(1, "seyda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();

            basketBuilder.CreateBasket(101, ProductsList, basket);
            basketBuilder.CreateBasket(102, ProductsList, basket);

            OrderBuilder_01 orderBuilder = new OrderBuilder_01(1, ProductsList, CustomerList, basket, customer);

            

            productTransactions.FindPrice(101, ProductsList);
            Console.WriteLine();
            productTransactions.FindStock(101, ProductsList);
            Console.WriteLine();
            productTransactions.FindStock(11, ProductsList);
            Console.WriteLine();
            customerTransactions.ShowAccount(1, CustomerList,   basket);
            Console.WriteLine();
            customerTransactions.ShowAccount(11, CustomerList, basket);
            Console.WriteLine();
            productTransactions.ShowProductsCategory("Beverages", ProductsList);
            Console.WriteLine();
            customerTransactions.LogOut(1, CustomerList);
            
        }
    }
}