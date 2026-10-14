namespace SandBox.InterfacesSection
{
    internal class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment amount: {amount}");
        }
    }
}
