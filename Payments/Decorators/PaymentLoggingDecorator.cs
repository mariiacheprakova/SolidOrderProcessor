using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;
using SolidOrderProcessor.Strategies;

namespace SolidOrderProcessor.Payments.Decorators;
public class PaymentLoggingDecorator : IPaymentStrategy
{
    private readonly IPaymentStrategy _wrappedStrategy;
    private readonly ILogger _logger;
    public PaymentLoggingDecorator(IPaymentStrategy wrappedStrategy, ILogger logger)
    {
        _wrappedStrategy = wrappedStrategy;
        _logger = logger;
    }
    public PaymentMethod SupportedPaymentMethod => _wrappedStrategy.SupportedPaymentMethod;
    public void Pay(Order order)
    {
        _logger.Log("Payment started.");
        _wrappedStrategy.Pay(order);
        _logger.Log("Payment finished.");
    }
}
