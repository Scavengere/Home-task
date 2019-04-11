using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Girl : Human
    {
        public bool HaveABoyfriend { get; set; }
        public string NameOfBoyfriend { get; set; }
        public string Status { get; set; }
        public Girl()
        {
            Name = "-";
            Age = 0;
            Sex = "Girld";
            HaveABoyfriend = false;
            NameOfBoyfriend = "-";
            Status = "-";
        }
        public Girl(string name, int age, bool haveABoyfriend = false, string nameOfBoyfriend = "-")
        {
            Name = name;
            Age = age;
            Sex = "Girl";
            HaveABoyfriend = haveABoyfriend;
            NameOfBoyfriend = "-";
            if (haveABoyfriend)
                NameOfBoyfriend = nameOfBoyfriend;
            Status = "-";
        }
        public override void GoSleep()
        {
            Console.WriteLine($"{Name} goes to sleep.");
            Status = "Sleeping";
        }
        public override void GoEat()
        {
            Console.WriteLine($"{Name} goes to eat.");
            Status = "Eating";
        }
        public override void LeisureTime()
        {
            Random rand = new Random();
            int randomrandomAction = rand.Next(0, 5);
            switch (randomrandomAction)
            {
                case 0:
                    GoSleep();
                    break;
                case 1:
                    GoReadBook();
                    break;
                case 2:
                    GoCallFriend();
                    break;
                case 3:
                    GoShopping();
                    break;
                case 4:
                    WriteToYourBoyfriend();
                    break;
            }
        }
        public void GoReadBook()
        {
            Console.WriteLine($"{Name} goes to read a book.");
            Status = "Read book";
        }
        public void GoCallFriend()
        {
            Console.WriteLine($"{Name} goes to call friend.");
            Status = "Call friend";
        }
        public void GoShopping()
        {
            Console.WriteLine($"{Name} goes shopping.");
            Status = "Go shopping";
        }
        public void WriteToYourBoyfriend()
        {
            if (HaveABoyfriend)
            {
                Console.WriteLine($"{Name} writes {NameOfBoyfriend}.");
                Status = "Write her boyfriend";
            }
            else
            {
                Console.WriteLine($"The {Name} has not a boyfriend.");
                Status = "Trying to write non-existent boyfriend.";
            }
        }
        public override void OutputInformation()
        {
            Console.WriteLine($"{Name}  {Sex}  {Age}  {Status}  {HaveABoyfriend}  {NameOfBoyfriend}");
        }
    }
}
