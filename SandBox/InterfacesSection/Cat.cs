namespace SandBox.InterfacesSection
{
    internal class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Cat eats " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
