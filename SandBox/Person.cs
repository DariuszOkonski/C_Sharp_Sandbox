namespace SandBox
{
    internal class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
