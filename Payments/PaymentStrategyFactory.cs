using SolidOrderProcessor.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;
using System.Security.Cryptography.X509Certificates;

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
          _ => throw new ArgumentException("Unsupported payment method.") 

        };
    }

}
