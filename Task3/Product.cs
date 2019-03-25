using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Product
    {
        public string NameOfProduct { get; set; }
        public int AmountOfProduct { get; set; }
        public int PriceOfProduct { get; set; }
        public Product()
        {
            NameOfProduct = "";
            AmountOfProduct = 0;
            PriceOfProduct = 0;
        }
    }
}
