namespace SandBox
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 5, 31);

            Console.WriteLine("My birthday is {0}", dateTime);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);



            Console.ReadKey();
        }
    }
}
