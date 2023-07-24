using System.Drawing;

namespace _211229001_Composite
{

    class Program
    {

        static void Main(string[] args)
        {
            FactoryCustomer_01 factory = new FactoryCustomer_01(1, "Customer", "Customer", "Customer", 1, 1, "Customer", "Customer", "Customer", false);
            CustomerObject_01 customer = new BronzCustomer_01(1, "Seyda", "Acikgoz", "Konya", 1230, 15, "Bronz", "seyda@gmail.com", "123Seyda", false);
            List<CustomerObject_01> CustomerList = new List<CustomerObject_01>() { customer };
            factory.AddCustomers(customer);
            factory.ListCustomers();


            FactoryProduct_01 productFactory = new FactoryProduct_01(1, "Product", "Product", 1, 1);

            ProductObject_01 product1 = new Beverages_01(101, "Chai", "Beverages", 39, 18);
            ProductObject_01 product2 = new Beverages_01(102, "Chang", "Beverages", 17, 19);
            ProductObject_01 product3 = new Beverages_01(103, "Guarana Fantastica", "Beverages", 20, 4.5);
            ProductObject_01 product4 = new Confections_01(201, "Konbu", "Confections", 24, 6);
            ProductObject_01 product5 = new Confections_01(202, "Pavlova", "Confections", 29, 17.45);
            ProductObject_01 product6 = new Confections_01(203, "Sir Rodney's Marmalade", "Confections", 40, 81);
            ProductObject_01 product7 = new GrainsCereals_01(301, "Ikura", "GrainsCereals", 31, 31);
            ProductObject_01 product8 = new GrainsCereals_01(302, "Tofu", "GrainsCereals", 35, 25.25);
            ProductObject_01 product9 = new GrainsCereals_01(303, "Tunnbröd", "GrainsCereals", 61, 9);

            List<ProductObject_01> ProductsList = new List<ProductObject_01>() { product1, product2, product3, product4, product5, product6, product7, product8, product9 };
            productFactory.AddProducts(product1);
            productFactory.AddProducts(product2);
            productFactory.AddProducts(product3);
            productFactory.AddProducts(product4);
            productFactory.AddProducts(product5);
            productFactory.AddProducts(product6);
            productFactory.AddProducts(product7);
            productFactory.AddProducts(product8);
            productFactory.AddProducts(product9);
           

            productFactory.ListProducts();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            FactoryProduct_01 productObject = new FactoryProduct_01(1, "Product", "Product", 1, 1);
            
            productObject.LogIn(5, "seyda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            productObject.LogIn(1, "seda@gmail.com", "123Seyda",CustomerList);
            Console.WriteLine();
            productObject.LogIn(1, "seyda@gmail.com", "123Seyda",CustomerList);
            Console.WriteLine();
            productObject.ShowBasket();
            Console.WriteLine();
            productObject.AddBasket(1, 101,ProductsList);
            productObject.AddBasket(1, 102, ProductsList);
            Console.WriteLine();
            productObject.ShowBasket();
            Console.WriteLine();
            productObject.FindPrice(101,ProductsList);
            Console.WriteLine();
            productObject.FindPrice(11,ProductsList);
            Console.WriteLine();
            productObject.FindStock(101,ProductsList);
            Console.WriteLine();
            productObject.FindStock(11,ProductsList);
            Console.WriteLine();
            productObject.ShowProductsCategory("Beverages",ProductsList);
            

            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            customer.LogIn(5, "seyda@gmail.com", "123Seyda",CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seda@gmail.com", "123Seyda", CustomerList);
            Console.WriteLine();
            customer.LogIn(1, "seyda@gmail.com", "123Seyda",CustomerList);
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.AddBasket(1, 101, ProductsList);
            customer.AddBasket(1, 102, ProductsList);
            Console.WriteLine();
            customer.ShowBasket();
            Console.WriteLine();
            customer.Buy(1,ProductsList,CustomerList);
            Console.WriteLine();
            customer.Buy(1,ProductsList,CustomerList);
            Console.WriteLine();
            customer.FindPrice(101, ProductsList);
            Console.WriteLine();
            customer.FindStock(101,ProductsList);
            Console.WriteLine();
            customer.FindStock(11, ProductsList);
            Console.WriteLine();
            customer.ShowAccount(1, CustomerList);
            Console.WriteLine();
            customer.ShowAccount(11,CustomerList);
            Console.WriteLine();
            customer.ShowProductsCategory("Beverages",ProductsList);
            Console.WriteLine();
            customer.LogOut(1,CustomerList);

        }
    }
}