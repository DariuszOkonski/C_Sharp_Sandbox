namespace SandBox.EventsAndDelegates
{
    public delegate int MyComparison<T>(T x, T y);

    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
