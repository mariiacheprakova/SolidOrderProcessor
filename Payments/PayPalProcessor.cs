using SolidOrderProcessor.Models;
using SolidOrderProcessor.Persistence;
namespace SolidOrderProcessor.Payments;


public class PayPalProcessor : IPaymentProcessor
{
    private readonly ILogger _logger;
    public PayPalProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public PaymentMethod SupportedMethod => PaymentMethod.PayPal;
    public void ProcessingPayment(Order order) => _logger.Log("Paid with PayPal");
}

