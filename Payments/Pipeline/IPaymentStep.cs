namespace SolidOrderProcessor.Payments.Pipeline;
public interface IPaymentStep
{
    Task HandleAsync(decimal amount, Func<Task> next);
}
