namespace SolidOrderProcessor.Payments.Pipeline;
public class PaymentPipeline : IPaymentPipeline
{
    private readonly List<IPaymentStep> _steps;
    public PaymentPipeline(IEnumerable<IPaymentStep> steps)
    {
        _steps = steps.ToList();
    }
    public Task Execute(decimal amount)
    {
        return ExecuteStep(0, amount);
    }
    private Task ExecuteStep(int index, decimal amount)
    {
        if (index >= _steps.Count)
        {
            return Task.CompletedTask;
        }
        return _steps[index].Handle(
            amount,
            () => ExecuteStep(index + 1, amount));
    }
}