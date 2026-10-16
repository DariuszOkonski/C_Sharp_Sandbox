namespace SandBox
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();

            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);
            app.DoWork();



            Console.ReadKey();
        }
    }
}
