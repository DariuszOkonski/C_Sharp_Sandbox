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

            Predicate<int> isGreaterOrEqualThenTen = x => x >= 10;

            List<int> higherEqualTen = numbers.FindAll(isGreaterOrEqualThenTen);
            //higherEqualTen.Sort();

            Console.WriteLine();
            Console.WriteLine("All numbers here");
            foreach (int number in higherEqualTen)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
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
