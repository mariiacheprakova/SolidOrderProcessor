
using SolidOrderProcessor.Models;
namespace SolidOrderProcessor.Payments;

public interface IPaymentProcessor
{
    void PaymentMethod(Order order);
}

