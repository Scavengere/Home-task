using System;

namespace Task19
{
    class AgeException : ArgumentException
    {
        public int Age { get; }
        public AgeException(string message, int age) : base(message)
        {
            Age = age;
        }
    }
}
