namespace SandBox.EventsAndDelegates
{
    internal class PersonSorter
    {
        public void Sort(Person[] people, MyComparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }

        public static void RunApp()
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
