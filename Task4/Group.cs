using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Group
    {
        public static Random rand = new Random();
        public static List<IAnimal> Animals = new List<IAnimal>();
        
        public static void AddBear(string name, int age, string sex)
        {
            Animals.Add(new Bear(name, age, sex, rand));
        }
        public static void AddElephant(string name, int age, string sex)
        {
            Animals.Add(new Elephant(name, age, sex, rand));
        }
        public static void AddMonkey(string name, int age, string sex)
        {
            Animals.Add(new Monkey(name, age, sex, rand));
        }
        public static void AddTiger(string name, int age, string sex)
        {
            Animals.Add(new Tiger(name, age, sex, rand));
        }
        public static void AddWolf(string name, int age, string sex)
        {
            Animals.Add(new Wolf(name, age, sex, rand));
        }
        public static void OutputAllAnimals()
        {
            foreach (IAnimal animal in Animals)
                Console.WriteLine($"{animal}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");
        }

    }
}
