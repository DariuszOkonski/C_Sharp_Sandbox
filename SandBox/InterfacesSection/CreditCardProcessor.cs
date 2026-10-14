namespace SandBox.InterfacesSection
{
    internal class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment amount: {amount}");
            // implement credit card payment logic.
        }
    }
}
