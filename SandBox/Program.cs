using SandBox.Structs;

namespace SandBox
{

    internal partial class Program
    {

        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            p1.Display();

            Point p2 = new Point(20, 30);
            p2.Display();

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"Distance between points: {distance:F2}");

            Point p3 = p1;
            p1.Display();
            p3.Display();


            Console.ReadKey();
        }
    }
}
