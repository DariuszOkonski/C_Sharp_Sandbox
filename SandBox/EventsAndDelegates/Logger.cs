namespace SandBox.EventsAndDelegates
{
    public delegate void LogHandler(string message);
    public class Logger
    {
        public static void RunMain()
        {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            logHandler("Log this info!!!");

            Console.WriteLine("================");

            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }
            }

            Console.WriteLine("---");

            if (isMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }
            else
            {
                Console.WriteLine("LogToFile method not found");
            }

            if (logHandler != null)
            {
                InvokeSafely(logHandler, "After removing LogToFile");
            }
        }

        public static bool isMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if (logHandler == null)
            {
                return false;
            }

            foreach (var d in logHandler.GetInvocationList())
            {
                if (d == (Delegate)method)
                {
                    return true;
                }
            }

            return false;
        }

        public static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;

            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File log: " + message);
        }
    }
}
