namespace SandBox
{
    internal partial class Program
    {
        public class DatabaseLogger : ILogger
        {
            public void Log(string message)
            {
                // implement the logic to log a message to a database
                Console.WriteLine($"Logging to database: {message}");
            }
        }
    }
}
