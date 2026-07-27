using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Logging;

namespace SolidOrderProcessor.Payments;

public class PaymentAuditStep : IPaymentStep
{
    private readonly ILogger _logger;
    public PaymentAuditStep(ILogger logger) => _logger = logger;
    public async Task Handle(decimal amount, Func<Task> next)
    {
        _logger.Log($"Payment of {amount} completed successfully.");
        await next();
    }
}
