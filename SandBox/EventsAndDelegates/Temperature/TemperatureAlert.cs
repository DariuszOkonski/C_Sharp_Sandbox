namespace SandBox.EventsAndDelegates.Temperature
{
    internal class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Alert: " + message);
        }
    }
}
