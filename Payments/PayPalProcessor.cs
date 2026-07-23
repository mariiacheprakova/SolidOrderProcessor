namespace SolidOrderProcessor.Payments;

    public class PayPalProcessor : IPaymentProcessor
    {
    public void PaymentMethod(Order order) => Console.WriteLine("Paid with PayPal");
    }

