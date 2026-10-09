namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();

            animal.MakeSound();
            cat.MakeSound();
            dog.MakeSound();

            Console.ReadKey();
        }
    }
}
