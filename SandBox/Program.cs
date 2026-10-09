namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe", 36, "Programmer", 1);
            joe.DisplayPersonInfo();

            Console.ReadKey();
        }
    }
}
