namespace SandBox.EventsAndDelegates.Temperature
{
    internal class TempCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"TEMP COOLING ALERT: temperature is {e.Temperature}" +
                $" sender is: {sender}");
        }
    }
}
