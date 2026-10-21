using SandBox.EventsAndDelegates;

namespace SandBox
{
    public delegate void LogHandler(string message);

    internal partial class Program
    {

        static void Main(string[] args)
        {
            Logger logger = new Logger();

            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;

            logHandler("Log to file");


            Console.ReadKey();
        }

    }
}
