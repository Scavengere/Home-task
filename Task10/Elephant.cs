using System;

namespace Task10
{
    class Elephant : WildAnimal, ICanEat, ICanMove, ICanSleep
    {
        public Elephant()
        {
            Name = "";
            Age = 0;
            Sex = "";
        }
        public Elephant(string name, int age, string sex, TypeOfAnimalNutrition typeOfAnimalNutrition, DistributionZone distributionZone, Random rand)
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
