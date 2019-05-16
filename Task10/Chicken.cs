using System;

namespace Task10
{
    class Chicken : HomeAnimal, ICanEat, ICanMove, ICanSleep
    {
        public Chicken()
        {
            Name = string.Empty;
            Age = 0;
            Sex = string.Empty;
        }
        public Chicken(string name, int age, string sex, Products products, LevelOfProfit levelOfProfit, Random rand)
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
            Console.WriteLine("Chicken is eating.");
        }
        public void Move()
        {
            Console.WriteLine("Chicken is moving.");
        }
        public void Sleep()
        {
            Console.WriteLine("Chicken is sleeping.");
        }
    }
}
