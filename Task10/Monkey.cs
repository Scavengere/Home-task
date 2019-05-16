using System;

namespace Task10
{
    class Monkey : WildAnimal, ICanEat, ICanMove, ICanSleep
    {
        public Monkey()
        {
            Name = "";
            Age = 0;
            Sex = "";
        }
        public Monkey(string name, int age, string sex, TypeOfAnimalNutrition typeOfAnimalNutrition, DistributionZone distributionZone, Random rand)
        {
            Name = name;
            Age = age;
            Sex = sex;
            TypeOfAnimalNutrition = typeOfAnimalNutrition;
            DistributionZone = distributionZone;
            CurrentOccupation = (Status)rand.Next(0, 3);
        }
        public void Eat()
        {
            Console.WriteLine("Monkey is eating.");
        }
        public void Move()
        {
            Console.WriteLine("Monkey is moving.");
        }
        public void Sleep()
        {
            Console.WriteLine("Monkey is sleeping.");
        }
    }
}
