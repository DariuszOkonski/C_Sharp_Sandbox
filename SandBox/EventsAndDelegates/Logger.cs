namespace SandBox.EventsAndDelegates
{
    public delegate void LogHandler(string message);
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File log: " + message);
        }

        public static void RunApp()
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            logHandler("Log this info!!!");

            Console.WriteLine("---");

            logHandler -= logger.LogToFile;

            logHandler("After removing LogToFile");
        }
    }
}
