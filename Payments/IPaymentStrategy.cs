
using SolidOrderProcessor.Models;
namespace SolidOrderProcessor.Payments;

public interface IPaymentStrategy
{
    PaymentMethod SupportedMethod { get; }
    public void ProcessingPayment(Order order);
}

