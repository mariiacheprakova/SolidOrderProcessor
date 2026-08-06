using SolidOrderProcessor.Logging;

namespace SolidOrderProcessor;
public abstract class PaymentProcessor
{
    protected readonly ILogger Logger;
    public PaymentProcessor(ILogger logger)
    {
       Logger = logger;
    }
    public abstract void ProcessPayment();
}
public class RevolutProcessor : PaymentProcessor
{
    public RevolutProcessor(ILogger logger) : base(logger) { }
    public override void ProcessPayment()
    {
        Logger.Log("Payment by Revolu processed.");
    }
}
public class BrokenPaymentProcessor : PaymentProcessor
{
    public BrokenPaymentProcessor(ILogger logger) : base(logger) { }
    public override void ProcessPayment()
    {
        //throw new NotSupportedException(
        //    "This payment processor cannot process payments.");
        Logger.Log("An exception will be implemented here.");
    }
}

