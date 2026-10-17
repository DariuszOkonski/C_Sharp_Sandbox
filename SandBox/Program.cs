using SandBox.InterfacesSection;

namespace SandBox
{

    internal partial class Program
    {

        static void Main(string[] args)
        {
            MultiFunctionPrinter printer = new MultiFunctionPrinter();

            printer.Print();
            printer.Scan();

            Console.ReadKey();
        }
    }
}
