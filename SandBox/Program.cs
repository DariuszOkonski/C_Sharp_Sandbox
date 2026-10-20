namespace SandBox
{

    internal partial class Program
    {
        // 1.Declaration
        public delegate void Notify(string message);

        static void Main(string[] args)
        {

            // 2.Instantiation
            Notify notifyDelegate1 = ShowMessage;
            Notify notifyDelegate2 = new Notify(ShowMessage);

            notifyDelegate1("message-1");
            notifyDelegate2("message-2");

            Console.ReadKey();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

    }
}
