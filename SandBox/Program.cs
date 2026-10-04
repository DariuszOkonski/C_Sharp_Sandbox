namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int>() { 10, 5, 15, 3, 9, 25, 18 };

            Console.WriteLine("Unsorted list");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // define the predicate to check if a number is greather than 10
            //Predicate<int> isGreaterThenTenPredicate = x => x > 10;
            Predicate<int> isGreaterThenTenPredicate = IsGreaterThenTen;

            List<int> higherThenTen = numbers.FindAll(isGreaterThenTenPredicate);
            //higherEqualTen.Sort();

            Console.WriteLine();
            Console.WriteLine("All numbers here");
            foreach (int number in higherThenTen)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }

        public static bool IsGreaterThenTen(int x)
        {
            return x > 10;
        }

        static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Address: " + customer.Address);
            Console.WriteLine("Contact Number: " + customer.ContactNumber);
            Console.WriteLine();
        }
    }
}
