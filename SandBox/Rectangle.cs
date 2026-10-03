namespace SandBox
{
    internal class Rectangle
    {
        public const int NumberOfCorners = 4;
        public readonly string Color;

        public Rectangle(string color)
        {
            Color = color;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Color: {Color}, Width: {Width}, Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners}");
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}
