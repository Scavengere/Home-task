using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Customer
    {
        public string NameOfCustomer { get; set; }
        public int BalanceOfCustomer { get; set; }
        public Customer()
        {
            NameOfCustomer = "";
            BalanceOfCustomer = 0;
        }
        public Customer(string name)
        {
            NameOfCustomer = name;
            Random rand = new Random();
            BalanceOfCustomer = rand.Next(0,101);
        }
        public Customer(string name, int balance)
        {
            NameOfCustomer = name;
            BalanceOfCustomer = balance;
        }
    }
}
