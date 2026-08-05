namespace SolidOrderProcessor.Payments.Pipeline;
public interface IPaymentPipeline 
{
    Task Execute(decimal amount);
}
