using System;

namespace Task19
{
    class NameException : ArgumentException
    {
        public string Name { get; }
        public NameException(string message, string name) : base(message)
        {
            Name = name;
        }
    }
}
