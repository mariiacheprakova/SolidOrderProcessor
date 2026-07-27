using SolidOrderProcessor.Models;
using SolidOrderProcessor.Logging;
namespace SolidOrderProcessor.Payments;
using SolidOrderProcessor.Models;

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