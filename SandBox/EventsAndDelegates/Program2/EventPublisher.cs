namespace SandBox.EventsAndDelegates.Program2
{
    internal class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }
}
