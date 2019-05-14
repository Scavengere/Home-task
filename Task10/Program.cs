using System;
using System.Linq;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Group();
            Console.WriteLine("Animals:");
            group.Add(new Bear("Миша", 10, "M", Group.rand));
            group.Add(new Bear("Настя", 9, "F", Group.rand));
            group.Add(new Elephant("Лунтик", 5, "F", Group.rand));
            group.Add(new Elephant("Чебурашка", 12, "M", Group.rand));
            group.Add(new Monkey("Фокся", 2, "F", Group.rand));
            group.Add(new Monkey("Света", 6, "F", Group.rand));
            group.Add(new Tiger("Маша", 6, "F", Group.rand));
            group.Add(new Tiger("Cаша", 9, "M", Group.rand));
            group.Add(new Wolf("Маркиз", 3, "M", Group.rand));
            group.Add(new Wolf("Максим", 6, "M", Group.rand));
            group.OutputAllAnimals();

            Console.WriteLine();
            Console.WriteLine("Only male:");
            var onlyMale = from animal in Group.Animals
                           where animal.Sex == "M"
                           select animal;
            foreach(IAnimal animal in onlyMale)
                Console.WriteLine($"{animal}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");

            Console.WriteLine();
            Console.WriteLine("Only older than 8 years:");
            var olderThan8Years = from animal in Group.Animals
                                  where animal.Age > 8
                                  select animal;
            foreach (IAnimal animal in olderThan8Years)
                Console.WriteLine($"{animal}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");

            Console.WriteLine();
            Console.WriteLine("Only who sleep:");
            var onlyWhoSleep = from animal in Group.Animals
                               where animal.CurrentOccupation == "Sleep"
                               select animal;
            foreach (IAnimal animal in onlyWhoSleep)
                Console.WriteLine($"{animal}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");

            Console.ReadKey();
        }
    }
}
