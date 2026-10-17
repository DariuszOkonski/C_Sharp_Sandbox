namespace SandBox.InterfacesSection
{
    internal class Builder
    {
        private Hammer _hammer;
        private Saw _saw;

        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House is Build");
        }
    }
}
