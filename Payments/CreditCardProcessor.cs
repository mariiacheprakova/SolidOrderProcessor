using SolidOrderProcessor.Models;
using SolidOrderProcessor.Persistence;
namespace SolidOrderProcessor.Payments;

public class CreditCardProcessor : IPaymentProcessor
{
    private readonly ILogger _logger;
    public CreditCardProcessor(ILogger logger)
    {
        _logger = logger;
    }
    public PaymentMethod SupportedMethod => PaymentMethod.CreditCard;
    public void ProcessingPayment(Order order) => _logger.Log("Paid with credit card");

}

