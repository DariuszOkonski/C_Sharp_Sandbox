namespace SandBox.InterfacesSection
{
    internal class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document");
        }
    }
}
