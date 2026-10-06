namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if (codes.TryGetValue("NY1", out string state))
            {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The state code is {item.Key}: {item.Value}");
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
