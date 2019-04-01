using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Wolf : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string CurrentOccupation { get; set; }

        public Wolf(string name, int age, string sex, Random rand)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Status status = (Status)rand.Next(0, 3);
            CurrentOccupation = status.ToString();
        }
        public void Eat()
        {
            Console.WriteLine("Wolf is eating.");
        }

        public void Move()
        {
            Console.WriteLine("Wolf is moving.");
        }

        public void Sleep()
        {
            Console.WriteLine("Wolf is sleeping.");
        }
    }
}
