using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Group.AddBear("Миша", 10, "M");
            Group.AddElephant("Лунтик", 5, "F");
            Group.AddMonkey("Фокся", 2, "F");
            Group.AddTiger("Маша", 6, "M");
            Group.AddWolf("Маркиз",3, "M");
            Group.OutputAllAnimals();
            Console.ReadKey();
        }
    }
}
