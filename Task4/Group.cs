using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Group <T> where T: IAnimal, new()
    {
        public static Random rand = new Random();
        public static List<T> Animals = new List<T>();

        public static void Add(string name, int age, string sex)
        {
            T temp = new T();
            temp.Name = name;
            temp.Age = age;
            temp.Sex = sex;
            Status status = (Status)rand.Next(0, 3);
            temp.CurrentOccupation = status.ToString();
            Animals.Add(temp);
        }
        public static void OutputAllAnimals()           //Предполагается, что будут выведены все животные одного типа
        {
            foreach (IAnimal animal in Animals)
                Console.WriteLine($"{animal}  {animal.Name}  {animal.Age}  {animal.Sex} {animal.CurrentOccupation}");
        }

    }
}
