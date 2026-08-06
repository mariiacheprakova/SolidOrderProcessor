using SolidOrderProcessor.Models;
using SolidOrderProcessor.Payments;

namespace SolidOrderProcessor.Strategies;
public interface IPaymentStrategy
{
    PaymentMethod SupportedPaymentMethod { get; }
    public void Pay(Order order);
}

