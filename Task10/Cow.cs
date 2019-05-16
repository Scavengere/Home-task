using System;

namespace Task10
{
    class Cow : HomeAnimal, ICanEat, ICanMove, ICanSleep
    {
        public Cow()
        {
            Name = string.Empty;
            Age = 0;
            Sex = string.Empty;
        }
        public Cow(string name, int age, string sex, Products products, LevelOfProfit levelOfProfit, Random rand)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Products = products;
            Profit = levelOfProfit;
            CurrentOccupation = (Status)rand.Next(0, 3);
        }
        public void Eat()
        {
            Console.WriteLine("Cow is eating.");
        }
        public void Move()
        {
            Console.WriteLine("Cow is moving.");
        }
        public void Sleep()
        {
            Console.WriteLine("Cow is sleeping.");
        }
    }
}
