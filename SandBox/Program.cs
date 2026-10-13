namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee joe = new Employee("Joe", 36, "Programmer", 12345);
            //joe.DisplayPersonInfo();

            Manager carl = new Manager("Carl", 45, "Manager", 123123, 7);

            carl.BecomeOlder(5);
            carl.DisplayManagerInfo();


            Console.ReadKey();
        }
    }
}
