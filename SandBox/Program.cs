namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collie myCollie = new Collie();

            myCollie.Eat();
            myCollie.Bark();
            myCollie.GoingNuts();

            Console.ReadKey();
        }
    }
}
