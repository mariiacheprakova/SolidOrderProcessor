
using SolidOrderProcessor.Models;
namespace SolidOrderProcessor.Payments;

public interface IPaymentStrategy
{
    PaymentMethod SupportedPaymentMethod { get; }
    public void Pay(Order order);
}

