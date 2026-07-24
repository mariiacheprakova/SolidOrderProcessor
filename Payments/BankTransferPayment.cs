using SolidOrderProcessor.Models;
using SolidOrderProcessor.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Payments;

public class BankTransferPayment : IPaymentStrategy
{
    private readonly ILogger _logger;
    public BankTransferPayment(ILogger logger) => _logger = logger;
    public PaymentMethod SupportedMethod => PaymentMethod.BankTransfer;
    public void ProcessingPayment(Order order) => _logger.Log("Paid using bank transfer");

}

