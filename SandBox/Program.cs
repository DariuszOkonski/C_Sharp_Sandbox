using SandBox.InterfacesSection;

namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PayPalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);


            Console.ReadKey();
        }
    }
}
