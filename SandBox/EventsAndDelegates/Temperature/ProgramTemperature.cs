namespace SandBox.EventsAndDelegates.Temperature
{
    //public delegate void TemperatureChangeHandler(string message);

    internal class ProgramTemperature
    {
        public static void MainRun()
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();

            monitor.Temperature = 20;
            //monitor.OnTemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert.OnTemperatureChanged;


            Console.WriteLine("Please enter the temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine());

        }
    }
}
