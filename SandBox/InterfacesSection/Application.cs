namespace SandBox
{
    internal partial class Program
    {
        public class Application
        {
            private readonly ILogger _logger;
            public Application(ILogger logger)
            {
                _logger = logger;
            }

            public void DoWork()
            {
                _logger.Log("Work started");
                // do all the work
                _logger.Log("WORK DONE!");
            }
        }
    }
}
