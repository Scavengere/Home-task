using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jack = new Boy("Jack", 18, true, "Anna");
            jack.OutputInformation();
            jack.GoEat();
            jack.OutputInformation();
            jack.GoSleep();
            jack.OutputInformation();
            jack.LeisureTime();
            jack.OutputInformation();
            Console.WriteLine();
            Human marie = new Girl("Marie", 17, true, "Sam");
            marie.OutputInformation();
            marie.GoEat();
            marie.OutputInformation();
            marie.GoSleep();
            marie.OutputInformation();
            marie.LeisureTime();
            marie.OutputInformation();

            Console.ReadKey();
        }
    }
}
