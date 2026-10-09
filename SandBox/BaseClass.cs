namespace SandBox
{
    internal class BaseClass
    {
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, " +
                $"Protected: {protectedField}, Private: {protectedField}");
        }
    }
}
