namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products =
            [
                new Product { Name = "Apple", Price = 0.80 },
                new Product { Name = "Banana", Price = 0.30 },
                new Product { Name = "Cherry", Price = 3.80 },

            ];
            products.Add(new Product { Name = "Berries", Price = 2.99 });


            Console.WriteLine("Available products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for ${product.Price}");
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
