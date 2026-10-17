namespace SandBox.InterfacesSection
{
    internal class Builder
    {
        private Hammer _hammer;
        private Saw _saw;

        public Builder()
        {
            _hammer = new Hammer();
            _saw = new Saw();
        }

        public void Build()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House is Build");
        }
    }
}
