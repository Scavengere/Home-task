using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Elephant : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string CurrentOccupation { get; set; }
        public Elephant()
        {
            Name = "";
            Age = 0;
            Sex = "";
        }
        public Elephant(string name, int age, string sex, Random rand)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Status status = (Status)rand.Next(0, 3);
            CurrentOccupation = status.ToString();
        }
        public void Eat()
        {
            Console.WriteLine("Elephant is eating.");
        }

        public void Move()
        {
            Console.WriteLine("Elephant is moving.");
        }

        public void Sleep()
        {
            Console.WriteLine("Elephant is sleeping.");
        }
    }
}
