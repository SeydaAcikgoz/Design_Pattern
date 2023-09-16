using _211229001_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_ISP
{
    public enum CustomerType
    {
        Gold = 15, Silver = 10, Bronz = 5, Standard = 0
    }
    
    public class Customer_ISP_01 : ICustomerTranscations_ISP_01,IProductsTranscations_ISP_01
    {
        public int UserNo;
        public string UserName;
        public string UserSurname;
        public string Adress;
        public double UserAmount;
        public int Point = 0;
        public CustomerType customerType;
        public string Email;
        public string Password;
        public bool LoginStatus;

        public List<Customer_ISP_01> CustomerList = new List<Customer_ISP_01>();
        Products_ISP_01 Product = new Products_ISP_01();
        public bool login = false;
    
        public Customer_ISP_01()
        {
        }

        public Customer_ISP_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, CustomerType customerType, string email, string password, bool loginStatus)
        {
            this.UserNo = userno;
            this.UserName = userName;
            this.UserSurname = userSurname;
            this.Adress = adress;
            this.UserAmount = UserAmount;
            this.Point = point;
            this.customerType = customerType;
            this.Email = email;
            this.Password = password;
            this.LoginStatus = loginStatus;
        }

        public void LogIn(int cod, string email, string password, List<Customer_ISP_01> CustomerList)
        {
            CustomerList.ForEach(delegate (Customer_ISP_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    if (customer.Email.Equals(email) && customer.Password.Equals(password))
                    {
                        customer.LoginStatus = true;
                        login = true;
                        Console.WriteLine("Successfully logged in.Wellcome " + customer.UserName);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Email or Password wrong");
                        return;
                    }
                }
            });
            if (!login)
                Console.WriteLine("User not found!");
        }

        public void LogOut(int UserNo, List<Customer_ISP_01> CustomerList)
        {
            bool status = true;
            CustomerList.ForEach(delegate (Customer_ISP_01 customer)
            {
                if (customer.UserNo == UserNo)
                {
                    if (customer.LoginStatus == true)
                    {
                        customer.LoginStatus = false;
                        status = false;
                        Console.WriteLine("Successfully logged out");
                    }
                    else
                    {
                        Console.WriteLine("Already logged out");
                    }
                    return;
                }
            });
            if (status)
                Console.WriteLine("User not found!");
        }

        public void AddBasket(int USerCode, int ProductCode, List<Products_ISP_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
            {
                if (products.Code == ProductCode)
                {
                    if (products.Stock > 0)
                    {
                        product = true;
                        Product.basket.Add(products);
                        products.Stock--;
                    }
                    else
                    {
                        Console.WriteLine("Product sold out");
                    }
                }
            });
            if (!product)
                Console.WriteLine("Product not found!");
        }

        public void ShowBasket()
        {
            double total = 0;
            if (Product.basket.Count == 0)
            {
                Console.WriteLine("Basket is empty");
            }
            Product.basket.ForEach(delegate (Products_ISP_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.categoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void Shipping(Customer_ISP_01 customer)
        {
            Product.basket.ForEach(delegate (Products_ISP_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.categoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
            });

            Console.WriteLine("Listed products have been shipped to the address " + customer.Adress);
        }

        public void Buy(int UserCode, List<Products_ISP_01> ProductsList, List<Customer_ISP_01> CustomerList)
        {
            bool user = false;
            double total = 0;

            CustomerList.ForEach(delegate (Customer_ISP_01 customer)
            {
                if (customer.UserNo == UserCode)
                {
                    user = true;
                    if (customer.LoginStatus == true)
                    {
                        if (Product.basket.Count > 0)
                        {
                            Product.basket.ForEach(delegate (Products_ISP_01 product)
                            {
                                total += product.Price;
                            });
                        }
                        else
                        {
                            Console.WriteLine("Basket empty.");
                            return;
                        }

                        Console.WriteLine("Price:" + total);
                        total = total - (total * (int)(customer.customerType) / 100);
                        Console.WriteLine("Price after discount applied:" + total);

                        customer.Point += Product.basket.Count() * 10;
                        Console.WriteLine("Current point:" + customer.Point);

                        if (customer.UserAmount >= total)
                        {
                            customer.UserAmount -= total;
                            Console.WriteLine("Payment has been made.Purchase completed");
                            Shipping(customer);
                            Product.basket.Clear();
                        }
                        else
                        {
                            Console.WriteLine("There is not enough balance");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not logged in.Please loggin first.");
                        return;
                    }
                }
            });
            if (!user)
            {
                Console.WriteLine("User not found!");
            }
        }

        public void FindPrice(int ProductCode, List<Products_ISP_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
            {
                if (products.Code == ProductCode)
                {
                    product = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Price);
                }
            });
            if (!product)
                Console.WriteLine("Product not found!");
        }
        
        public void FindStock(int ProductCode, List<Products_ISP_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
            {
                if (products.Code == ProductCode)
                {
                    product = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!product)
                Console.WriteLine("Product not found!");
        }

        public void ShowAccount(int Usercode, List<Customer_ISP_01> CustomerList)
        {
            bool user = false;
            CustomerList.ForEach(delegate (Customer_ISP_01 customer)
            {
                if (customer.UserNo == Usercode)
                {
                    user = true;
                    Console.WriteLine(customer.UserName + "\t" + customer.UserSurname + "\t" + customer.Adress + "\t" + customer.Email + "\t" + customer.Password + customer.LoginStatus);
                    Console.WriteLine("Your basket:");
                    ShowBasket();
                }
            });
            if (!user)
                Console.WriteLine("User not found!");
        }

        public void ShowProductsCategory(CategoryType category, List<Products_ISP_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (Products_ISP_01 products)
            {
                if (products.categoryType == category)
                {
                    Category = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!Category) Console.WriteLine("Category not found");
        }
    }
}
