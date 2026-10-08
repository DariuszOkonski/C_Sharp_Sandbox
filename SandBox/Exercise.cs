namespace SandBox
{
    internal class Exercise
    {
        public void PrintWithFinally()
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }
    }
}
