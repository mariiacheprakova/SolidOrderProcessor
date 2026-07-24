using SolidOrderProcessor.Models;
using SolidOrderProcessor.Logging;
namespace SolidOrderProcessor.Payments;

public class PaymentService
{
    private readonly IEnumerable<IPaymentStrategy> _strategies;

    public PaymentService(IEnumerable<IPaymentStrategy> strategies)
    {
        _strategies = strategies;
    }

    public void ProcessPayment(Order order)
    {
        IPaymentStrategy strategy = _strategies.FirstOrDefault(
           payment => payment.SupportedMethod == order.PaymentMethod)
            ?? throw new InvalidOperationException(
                $"No strategy found for {order.PaymentMethod}.");

        strategy.ProcessingPayment(order);
    }
}