namespace SandBox.EventsAndDelegates.Temperature
{
    internal class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
