using SolidOrderProcessor.Persistence;

internal class PayPalPayment
{
    private ILogger logger;

    public PayPalPayment(ILogger logger)
    {
        this.logger = logger;
    }
}