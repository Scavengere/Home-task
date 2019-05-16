using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class HomeAnimal : IAnimal, IProduct
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public Status CurrentOccupation { get; set; }
        public Products Products { get; set; }
        public LevelOfProfit Profit { get; set; }
    }
}
