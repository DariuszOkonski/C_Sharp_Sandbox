namespace SandBox.EventsAndDelegates.Temperature
{
    internal class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature
        {
            get
            {
                return _temperature;
            }

            set
            {
                _temperature = value;

                if (_temperature > 30)
                {
                    // Raise Event
                    RaiseTemperatureChangedEvent("Temperature is above threshold!");
                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChanged?.Invoke(message);
        }
    }
}
