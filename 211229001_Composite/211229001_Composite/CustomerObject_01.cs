﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211229001_Composite
{
    public class CustomerObject_01:ICustomer_01
    {
        public int UserNo;
        public string UserName;
        public string UserSurname;
        public string Adress;
        public double UserAmount;
        public int Point;
        public string customerType;
        public string Email;
        public string Password;
        public bool LoginStatus;

        public List<CustomerObject_01> CustomerList = new List<CustomerObject_01>();


        public bool login = false;
        public CustomerObject_01()
        {
        }


        public CustomerObject_01(int userno, string userName, string userSurname, string adress, double UserAmount, int point, string customerType, string email, string password, bool loginStatus)
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

        ProductObject_01 Product = new ProductObject_01();

        public void LogIn(int cod, string email, string password, List<CustomerObject_01> CustomerList)
        {
            CustomerList.ForEach(delegate (CustomerObject_01 customer)
            {
                if (customer.UserNo == cod)
                {
                    LogInControl(email, password, customer);
                }
            });
            if (!login)
                Console.WriteLine("User not found!");

        }
        public void LogInControl(string email, string password, CustomerObject_01 customer)
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


        public void LogOut(int UserNo, List<CustomerObject_01> CustomerList)
        {
            bool status = true;
            CustomerList.ForEach(delegate (CustomerObject_01 customer)
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

        public void StockControl(ProductObject_01 products)
        {

            if (products.Stock > 0)
            {
                Product.basket.Add(products);
                products.Stock--;
            }
            else
            {
                Console.WriteLine("Product sold out");
            }

        }


        public void AddBasket(int USerCode, int ProductCode, List<ProductObject_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
            {
                if (products.Code == ProductCode)
                {
                    product = true;
                    StockControl(products);

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
            Product.basket.ForEach(delegate (ProductObject_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
                total += products.Price;
            });
            Console.WriteLine("Total price:" + total);
        }

        public void Shipping(CustomerObject_01 customer)
        {
            Product.basket.ForEach(delegate (ProductObject_01 products)
            {
                Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.CategoryType + "\t" + products.Price + "\t" + products.Stock + "\t");
            });

            Console.WriteLine("Listed products have been shipped to the address " + customer.Adress);

        }

        public void IncreasePoints(CustomerObject_01 customer)
        {
            customer.Point += Product.basket.Count() * 10;
            Console.WriteLine("Current point:" + customer.Point);
        }
        public void Payment(CustomerObject_01 customer, double total)
        {
            Console.WriteLine("Price:" + total);

            if (customer.customerType.Equals("Gold"))
            {
                total = total - (total * 15 / 100);
            }
            else if (customer.customerType.Equals("Silver"))
            {
                total = total - (total * 10 / 100);
            }
            else if (customer.customerType.Equals("Bronz"))
            {
                total = total - (total * 5 / 100);
            }

            Console.WriteLine("Price after discount applied:" + total);


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

        public void Buy(int UserCode, List<ProductObject_01> ProductsList, List<CustomerObject_01> CustomerList)
        {
            bool user = false;
            double total = 0;
            CustomerList.ForEach(delegate (CustomerObject_01 customer)
            {
                if (customer.UserNo == UserCode)
                {
                    user = true;
                    if (customer.LoginStatus == true)
                    {
                        if (Product.basket.Count > 0)
                        {
                            Product.basket.ForEach(delegate (ProductObject_01 product)
                            {
                                total += product.Price;
                            });
                        }
                        else
                        {
                            Console.WriteLine("Basket empty.");
                            return;
                        }
                        IncreasePoints(customer);
                        Payment(customer, total);

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


        public void FindPrice(int ProductCode, List<ProductObject_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
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
        public void FindStock(int ProductCode, List<ProductObject_01> ProductsList)
        {
            bool product = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
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

        public void ShowAccount(int Usercode, List<CustomerObject_01> CustomerList)
        {
            bool user = false;
            CustomerList.ForEach(delegate (CustomerObject_01 customer)
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

        public void ShowProductsCategory(string category, List<ProductObject_01> ProductsList)
        {
            bool Category = false;
            ProductsList.ForEach(delegate (ProductObject_01 products)
            {
                if (products.CategoryType.Equals(category))
                {
                    Category = true;
                    Console.WriteLine(products.Code + "\t" + products.ProductName + "\t" + products.Stock);
                }
            });
            if (!Category) Console.WriteLine("Category not found");
        }
    }
}
