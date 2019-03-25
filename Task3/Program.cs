using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop MyShop = new Shop("Valera");
            do
            {
                MyShop.LoadAssortment();
                Console.WriteLine($"Hello. My name is {Shop.NameOfSeller}.");
                string typeOfPeripheral;
                string productToCustomer;
                bool productInStock = false;
                int thePriceOfTheProduct;
                string action;
                do
                {
                    Console.WriteLine("What interests you: keyboard or mouse?");
                    typeOfPeripheral = Console.ReadLine().ToLower();
                    Console.WriteLine("Ok. What a model?");
                    productToCustomer = Console.ReadLine();
                    
                    thePriceOfTheProduct = MyShop.SearchingProductToCustomer(typeOfPeripheral, productToCustomer);
                    productInStock = MyShop.ProductInformation(typeOfPeripheral, productToCustomer, thePriceOfTheProduct);
                    if(productInStock == false)
                    {
                        do
                        {
                            Console.WriteLine("Maybe you are interested in something else?(Yes/No)");
                            action = Console.ReadLine();
                            action = CheckingYesOrNot(action);
                            if ((action == "Yes") || (action == "No"))
                                break;
                        } while (true);
                        if(action == "No")
                        {
                            Console.WriteLine("Come next time. Goodbye...");
                            Console.WriteLine("Press any button to switch to another customer...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        Console.Clear();
                    }
                } while (productInStock == false);
                if (productInStock == true)
                {
                    do
                    {
                        Console.WriteLine("Will you buy?(Yes/No)");
                        action = Console.ReadLine();
                        action = CheckingYesOrNot(action);
                        if ((action == "Yes") || (action == "No"))
                        {
                            break;
                        }
                    } while (true);
                    if (action == "No")
                    {
                        Console.WriteLine("Come next time. Goodbye...");
                        Console.WriteLine("Press any button to switch to another customer...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("What is your name?");
                        string nameOfCustomer = Console.ReadLine();
                        MyShop.NewClient(nameOfCustomer, productToCustomer, thePriceOfTheProduct);
                        Console.WriteLine("Ok. Now attach your card to the terminal.");
                        bool checkPayment = MyShop.PaymentOfPurchase();

                        if (checkPayment == true)
                        {
                            Console.WriteLine("Thank you for your purchase");
                            Console.WriteLine("Press any button to switch to another customer...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("There are not enough funds in your account.\nCome next time. Goodbye...");
                            Console.WriteLine("Press any button to switch to another customer...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        Console.WriteLine("Close the store and withdraw all orders for today?");
                        action = Console.ReadLine();
                        action = CheckingYesOrNot(action);
                        if (action == "Yes")
                        {
                            break;
                        }
                    }
                }
            } while (true);

            Shop.OutputAllOrders();
            Console.ReadKey();
        }

        public static string CheckingYesOrNot(string action)
        {
            if ((action == "Yes") || (action == "No"))
            {
                return action;
            }
            else
            {
                Console.WriteLine("I do not understand. Please repeat. (Press any key to repeat).");
                Console.ReadKey();
                Console.Clear();
                return "";
            }
        }
    }
}
