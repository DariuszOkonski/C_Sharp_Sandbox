namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Rob Smith");
            employees.Add(104, "Flob Smith");
            employees.Add(105, "Dob Smith");


            var name = employees[101];
            Console.WriteLine("Name: " + name);

            employees[102] = "Jane Smith";

            employees.Remove(102);

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"Id: {employee.Key} - {employee.Value}");
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
