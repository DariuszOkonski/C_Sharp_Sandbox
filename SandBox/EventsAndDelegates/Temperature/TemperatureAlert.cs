namespace SandBox.EventsAndDelegates.Temperature
{
    // subscripber
    internal class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is: {e.Temperature} sender is: {sender}");
        }
    }
}
