using System;

namespace Task10
{
    enum TypeOfAnimalNutrition
    {
        Herbivorous,
        Carnivorous
    }
    enum DistributionZone
    {
        Forest,
        Savannah,
        Jungle,
        Desert
    }
    class WildAnimal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public Status CurrentOccupation { get; set; }
        public TypeOfAnimalNutrition TypeOfAnimalNutrition { get; set; }
        public DistributionZone DistributionZone { get; set; }
    }

}
