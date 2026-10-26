namespace SandBox.EventsAndDelegates.Temperature
{
    internal class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        private int _temperature;
        public int Temperature
        {
            get
            {
                return _temperature;
            }

            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChangedEvent(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        protected virtual void OnTemperatureChangedEvent(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }
}
