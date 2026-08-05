using System.Diagnostics;
using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;
using SolidOrderProcessor.Strategies;

namespace SolidOrderProcessor.Payments.Decorators;
public class PaymentTimingDecorator : IPaymentStrategy
{
    private readonly ILogger _logger;
    private readonly IPaymentStrategy _wrappedStrategy;
    public PaymentTimingDecorator(ILogger logger,IPaymentStrategy wrappedStrategy)
    {
        _logger = logger;
        _wrappedStrategy = wrappedStrategy;
    }
    public PaymentMethod SupportedPaymentMethod => _wrappedStrategy.SupportedPaymentMethod;
    public void Pay(Order order)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        try
        {
            _wrappedStrategy.Pay(order);
        }
        finally
        {
            stopwatch.Stop();
            _logger.Log($"{SupportedPaymentMethod} payment took {stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}
