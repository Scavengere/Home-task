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
            Group<Bear>.Add("Миша", 10, "M");
            Group<Elephant>.Add("Лунтик", 5, "F");
            Group<Monkey>.Add("Фокся", 2, "F");
            Group<Tiger>.Add("Маша", 6, "M");
            Group<Wolf>.Add("Маркиз",3, "M");
           
            Group<Bear>.OutputAllAnimals();
            Group<Elephant>.OutputAllAnimals();
            Group<Monkey>.OutputAllAnimals();
            Group<Tiger>.OutputAllAnimals();
            Group<Wolf>.OutputAllAnimals();
            Console.ReadKey();
        }
    }
}
