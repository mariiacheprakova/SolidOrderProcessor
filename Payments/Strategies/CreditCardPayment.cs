using SolidOrderProcessor.Models;
using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Payments;

namespace SolidOrderProcessor.Strategies;
public class CreditCardPayment : IPaymentStrategy
{
    private readonly ILogger _logger;
    public CreditCardPayment(ILogger logger)
    {
        _logger = logger;
    }
    public PaymentMethod SupportedPaymentMethod => PaymentMethod.CreditCard;
    public void Pay(Order order) => _logger.Log("Paid with credit card");
}

