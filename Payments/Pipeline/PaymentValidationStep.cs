namespace SolidOrderProcessor.Payments.Pipeline;
public class PaymentValidationStep : IPaymentStep
{
    public async Task HandleAsync(decimal amount, Func<Task> next)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Payment amount must be greater than zero.");
        }
        await next();
    }
}
