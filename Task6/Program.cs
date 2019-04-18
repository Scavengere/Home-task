using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy Jack = new Boy("Jack", 18, true, "Anna");
            TypeInfo.ShowTypeInfo<Boy>(Jack);
            Console.ReadKey();
        }
    }
}
