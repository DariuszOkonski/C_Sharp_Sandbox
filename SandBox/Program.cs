using SandBox.EventsAndDelegates;

namespace SandBox
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person { Name = "Charlie", Age = 35 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Denis", Age = 36 },
                new Person { Name = "Alice", Age = 30 },
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            Console.WriteLine("Compare by age");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            Console.WriteLine();
            Console.WriteLine("Compare by name");

            sorter.Sort(people, CompareByName);
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            Console.ReadKey();
        }

        public static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        public static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
