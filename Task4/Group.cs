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

        public void Add<T>(T temp) where T: IAnimal, new()
        {
            Animals.Add(temp);
        }
        public void OutputAllAnimals()
        {
            foreach (IAnimal animal in Animals)
                Console.WriteLine($"{animal}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");
        }

    }
}
