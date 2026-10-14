namespace SandBox
{
    public class Exercise
    {
        public void DemonstrateOverriding()
        {

        }
    }

    public class Animal1
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog1 : Animal1
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat1 : Animal1
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
}
