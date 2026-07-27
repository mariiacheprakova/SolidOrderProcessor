using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Payments;

public class PaymentStrategyFactory : IPaymentStrategyFactory
{
    private readonly ILogger _logger;
    public PaymentStrategyFactory(ILogger logger) => _logger = logger;

    public IPaymentStrategy Create(PaymentMethod paymentMethod)
    {
        return paymentMethod switch
        { PaymentMethod.CreditCard => new CreditCardPayment(_logger),
            PaymentMethod.PayPal => new PayPalPayment(_logger),
            PaymentMethod.BankTransfer => new BankTransferPayment(_logger),
            _ => throw new ArgumentOutOfRangeException("Unsupported payment method.")

        };
    }
}
