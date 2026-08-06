using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;
using SolidOrderProcessor.Strategies;

namespace SolidOrderProcessor.Payments.Strategies;
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

