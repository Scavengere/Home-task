using System.Text.RegularExpressions;

namespace Task19
{
    class Worker
    {
        private string name;
        public string Name
        {
            set
            {
                Regex regex = new Regex(@"^[a-zA-Z\s,]*$");
                if(regex.IsMatch(value))
                        name = value;
                else throw new NameException("Name must contain only letters", value);
            }
            get
            {
                return name;
            }
        }
        private int age;
        public int Age
        {
            set
            {
                if (value >= 18) age = value;
                else
                    throw new AgeException("The age must be not less than 18", value);
                
            }
            get
            {
                return age;
            }
        }

        public Worker(string name, int a)
        {
            Name = name;
            Age = a;
        }
    }
}
