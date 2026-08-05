namespace SolidOrderProcessor.Payments.Pipeline;
public interface IPaymentStep
{
    Task Handle(decimal amount, Func<Task> next);
}
