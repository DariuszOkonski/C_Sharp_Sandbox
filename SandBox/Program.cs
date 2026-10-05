using System.Collections;

namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);


            myArrayList.Remove(13);
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);


            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine($"Sum: {sum}");


            Console.ReadKey();
        }

        public static bool IsGreaterThenTen(int x)
        {
            return x > 10;
        }

        static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Address: " + customer.Address);
            Console.WriteLine("Contact Number: " + customer.ContactNumber);
            Console.WriteLine();
        }
    }
}
