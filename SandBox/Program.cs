namespace SandBox
{

    internal partial class Program
    {

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            string[] stringArray = { "one", "two", "three", "four" };

            PrintArray(intArray);
            PrintArray(stringArray);


            Console.ReadKey();
        }

        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintStringArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
