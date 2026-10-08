namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("Main method is running");

            try
            {
                Console.WriteLine("Please enter a number");

                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;

                result = num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DONT DEVIDE BY ZERO!!!" + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("I TOLD YOU TO ENTER A NUMBER!!!" + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("NUMBER TO HIGHT!" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("This always executes");
            }

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
