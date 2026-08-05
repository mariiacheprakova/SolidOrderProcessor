using SolidOrderProcessor.Models;
using SolidOrderProcessor.Strategies;

namespace SolidOrderProcessor.Payments.Factories;
public interface IPaymentStrategyFactory
{
    IPaymentStrategy Create(PaymentMethod paymentMethod);
}
