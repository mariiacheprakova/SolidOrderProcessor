using SolidOrderProcessor.Models;
using SolidOrderProcessor.Payments;


namespace SolidOrderProcessor.Factories;

public interface IPaymentStrategyFactory
{
    IPaymentStrategy Create(PaymentMethod? paymentMethod);
}
