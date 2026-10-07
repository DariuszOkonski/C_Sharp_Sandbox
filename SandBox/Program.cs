namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            GetUserAge(Console.ReadLine());


            Console.ReadKey();
        }

        public static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }

            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }

            return age;
        }

        public static double Divide(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }

            return (numerator / denominator);
        }
    }
}
