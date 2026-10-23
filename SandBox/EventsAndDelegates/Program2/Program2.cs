namespace SandBox.EventsAndDelegates.Program2
{
    public delegate void Notify(string message);


    internal class Program2
    {
        public static void RunMain()
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber1 = new EventSubscriber();
            MyEventSubscriber subscriber2 = new MyEventSubscriber();

            publisher.OnNotify += subscriber1.DisplayEventSubscriberMessage;
            publisher.OnNotify += subscriber2.DisplayMessage;

            publisher.RaiseEvent("Hello World");
        }
    }
}
