using SolidOrderProcessor.Models;
using SolidOrderProcessor.Payments.Factories;

namespace SolidOrderProcessor.Strategies;
public class PaymentService
{
    private readonly IPaymentStrategyFactory _factory;
    public PaymentService(IPaymentStrategyFactory factory) => _factory = factory;
    public void ProcessPayment(Order order)
    {
        IPaymentStrategy strategy = _factory.Create(order.PaymentMethod);
        strategy.Pay(order);
    }
}
