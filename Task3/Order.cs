using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    enum Status { Processing = 0, Complete = 1, LackOfFunds = 2 }
    class Order
    {
        public int NumberOfOrder;
        public string NameOfCustomer;
        public string NameOfProduct;
        public int PriceOfProduct;
        public Status StatusOfOrder;
        public Order(int numberOfOrder, string nameOfCustomer, string nameOfProduct, int priceOfProduct)
        {
            NumberOfOrder = numberOfOrder;
            NameOfCustomer = nameOfCustomer;
            NameOfProduct = nameOfProduct;
            PriceOfProduct = priceOfProduct;
            StatusOfOrder = Status.Processing;
        }
        public void CompletedOrder()
        {
            StatusOfOrder = Status.Complete;
        }
        public void LackOfFunds()
        {
            StatusOfOrder = Status.LackOfFunds;
        }
    }
}
