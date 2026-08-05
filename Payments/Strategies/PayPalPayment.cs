using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Strategies;
public class PayPalPayment : IPaymentStrategy
{
    private readonly ILogger _logger;
    public PayPalPayment(ILogger logger)
    {
        _logger = logger;
    }
    public PaymentMethod SupportedPaymentMethod => PaymentMethod.PayPal;
    public void Pay(Order order) => _logger.Log("Paid with PayPal");
}

