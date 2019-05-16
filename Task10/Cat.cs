using System;

namespace Task10
{
    class Cat : HomeAnimal, ICanEat, ICanMove, ICanSleep
    {
        public Cat()
        {
            Name = string.Empty;
            Age = 0;
            Sex = string.Empty;
        }
        public Cat(string name, int age, string sex, Products products, LevelOfProfit levelOfProfit, Random rand)
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
            Console.WriteLine("Cat is eating.");
        }
        public void Move()
        {
            Console.WriteLine("Cat is moving.");
        }
        public void Sleep()
        {
            Console.WriteLine("Cat is sleeping.");
        }
    }
}
