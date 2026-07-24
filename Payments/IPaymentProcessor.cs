
using SolidOrderProcessor.Models;
namespace SolidOrderProcessor.Payments;

public interface IPaymentProcessor
{
    PaymentMethod SupportedMethod { get; }
    void ProcessingPayment(Order order);
}

