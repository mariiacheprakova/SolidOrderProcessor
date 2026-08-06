using SolidOrderProcessor.Models;
using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Strategies;

namespace SolidOrderProcessor.Payments.Strategies;
public class BankTransferPayment : IPaymentStrategy
{
    private readonly ILogger _logger;
    public BankTransferPayment(ILogger logger) => _logger = logger;
    public PaymentMethod SupportedPaymentMethod => PaymentMethod.BankTransfer;
    public void Pay(Order order) => _logger.Log("Paid using bank transfer.");
}

