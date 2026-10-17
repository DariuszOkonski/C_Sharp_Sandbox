using SandBox.InterfacesSection;

namespace SandBox
{

    internal partial class Program
    {

        static void Main(string[] args)
        {

            Builder builder = new Builder();

            builder.Build();


            Console.ReadKey();
        }
    }
}
