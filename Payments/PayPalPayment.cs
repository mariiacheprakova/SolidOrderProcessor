using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;
namespace SolidOrderProcessor.Payments;


public class PayPalPayment : IPaymentStrategy
{
    private readonly ILogger _logger;
    private ConsoleLogger logger;

    public PayPalPayment(ILogger logger)
    {
        _logger = logger;
    }

    public PaymentMethod SupportedMethod => PaymentMethod.PayPal;
    public void ProcessingPayment(Order order) => _logger.Log("Paid with PayPal");
}

