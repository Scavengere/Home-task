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
            var group = new Group();
            group.Add(new Bear("Миша", 10, "M", Group.rand));
            group.Add(new Elephant("Лунтик", 5, "F", Group.rand));
            group.Add(new Monkey("Фокся", 2, "F", Group.rand));
            group.Add(new Tiger("Маша", 6, "M", Group.rand));
            group.Add(new Wolf("Маркиз", 3, "M", Group.rand));
            group.OutputAllAnimals();
            Console.ReadKey();
        }
    }
}
