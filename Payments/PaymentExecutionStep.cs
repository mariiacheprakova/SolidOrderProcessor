using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Payments;

public class PaymentExecutionStep : IPaymentStep
{
    private readonly PaymentService _paymentService;
    private readonly Order _order;

    public PaymentExecutionStep(
        PaymentService paymentService,
        Order order)
    {
        _paymentService = paymentService;
        _order = order;
    }

    public async Task Handle(
        decimal amount,
        Func<Task> next)
    {
        _paymentService.ProcessPayment(_order);

        await next();
    }
}