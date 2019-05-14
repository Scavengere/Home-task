using System;

namespace Task10
{
    class Tiger : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string CurrentOccupation { get; set; }
        public Tiger()
        {
            Name = "";
            Age = 0;
            Sex = "";
        }
        public Tiger(string name, int age, string sex, Random rand)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Status status = (Status)rand.Next(0, 3);
            CurrentOccupation = status.ToString();
        }
        public void Eat()
        {
            Console.WriteLine("Tiger is eating.");
        }

        public void Move()
        {
            Console.WriteLine("Tiger is moving.");
        }

        public void Sleep()
        {
            Console.WriteLine("Tiger is sleeping.");
        }
    }
}
