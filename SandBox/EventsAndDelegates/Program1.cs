namespace SandBox.EventsAndDelegates
{
    public delegate void Notify(string message);

    internal class Program1
    {
        public static void Main()
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber1 = new EventSubscriber();
            EventSubscriber subscriber2 = new EventSubscriber();

            publisher.OnNotify += subscriber1.OnEventRaised;
            publisher.OnNotify += subscriber2.OnEventRaised;

            publisher.RaiseEvent("Hello World");
        }
    }

    public class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }
}
