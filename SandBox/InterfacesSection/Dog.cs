namespace SandBox.InterfacesSection
{
    internal class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
