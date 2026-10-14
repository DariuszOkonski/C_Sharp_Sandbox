using SandBox.InterfacesSection;

namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("treat");


            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("fish");


            Console.ReadKey();
        }
    }
}
