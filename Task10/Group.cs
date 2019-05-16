using System;
using System.Collections.Generic;

namespace Task10
{
    class Group<T> where T : IAnimal
    {
        public List<T> Animals { get; set; }
        public Group()
        {
            Animals = new List<T>();
        }
        public void OutputAllAnimals()
        {
            foreach (T animal in Animals)
                Console.WriteLine($"{animal.ToString().Remove(0,7)}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");
        }
    }
}
