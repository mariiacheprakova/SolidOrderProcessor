using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Payments;

public class PaymentService
{
    private readonly IEnumerable<IPaymentProcessor> _paymentProcessors;

    public PaymentService(IEnumerable<IPaymentProcessor> paymentProcessors)
    {
        _paymentProcessors = paymentProcessors;
    }

    public void ProcessPayment(Order order)
    {
        IPaymentProcessor processor = _paymentProcessors.FirstOrDefault(
            processor => processor.SupportedMethod == order.PaymentMethod)
            ?? throw new InvalidOperationException(
                "Unsupported payment method.");

        processor.ProcessingPayment(order);
    }
}