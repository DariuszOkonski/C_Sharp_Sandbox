namespace SandBox
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }
    }
}
