namespace SandBox
{
    internal partial class Program
    {
        public class FileLogger : ILogger
        {
            public void Log(string message)
            {
                string directoryPath = @"C:\Logs";
                string filePath = Path.Combine(directoryPath, "log.txt");

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.AppendAllText(filePath, message + "\n");
                Console.WriteLine($"Logging to file: {message}");
            }
        }
    }
}
