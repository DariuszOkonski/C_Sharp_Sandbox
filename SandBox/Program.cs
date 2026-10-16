namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {

            File.AppendAllText("log.txt", "Hello World" + "\n");


            Console.ReadKey();
        }
    }
}
