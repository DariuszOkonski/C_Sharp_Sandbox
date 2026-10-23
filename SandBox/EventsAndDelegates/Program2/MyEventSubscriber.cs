namespace SandBox.EventsAndDelegates.Program2
{
    internal class MyEventSubscriber
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine("MyEventSubscriber: " + message);
        }
    }
}
