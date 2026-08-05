using SolidOrderProcessor.Logging;

namespace SolidOrderProcessor.Payments.Pipeline;
public class PaymentAuditStep : IPaymentStep
{
    private readonly ILogger _logger;
    public PaymentAuditStep(ILogger logger) => _logger = logger;
    public async Task Handle(decimal amount, Func<Task> next)
    {
        await next();
        _logger.Log($"Payment of {amount} completed successfully.");
    }
}
