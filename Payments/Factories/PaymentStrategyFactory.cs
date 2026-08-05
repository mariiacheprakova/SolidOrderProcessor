using SolidOrderProcessor.Models;
using SolidOrderProcessor.Strategies;

namespace SolidOrderProcessor.Payments.Factories;
public class PaymentStrategyFactory : IPaymentStrategyFactory
{
    private readonly IEnumerable<IPaymentStrategy> _strategies;
    public PaymentStrategyFactory(IEnumerable<IPaymentStrategy> strategies)
    {
        _strategies = strategies;
    }
    public IPaymentStrategy Create(PaymentMethod paymentMethod)
    {
        return _strategies.First(strategy =>
            strategy.SupportedPaymentMethod == paymentMethod);
    }
}
