using SolidOrderProcessor.Persistence;

internal class CreditCardPayment
{
    private ILogger logger;

    public CreditCardPayment(ILogger logger)
    {
        this.logger = logger;
    }
}