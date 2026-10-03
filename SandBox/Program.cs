namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");




            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            colors.Remove("blue");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
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
