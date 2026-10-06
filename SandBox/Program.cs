namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("Please enter a number");

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;

                result = num2 / num1;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }
    }
}
