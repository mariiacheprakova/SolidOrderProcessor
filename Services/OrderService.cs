using SolidOrderProcessor.Models;
using SolidOrderProcessor.Notification;
using SolidOrderProcessor.Payments.Pipeline;
using SolidOrderProcessor.Persistence;
using SolidOrderProcessor.Validation;

namespace SolidOrderProcessor.Services;
public class OrderService
{
    private readonly ISendEmail _notificationService;
    private readonly IOrderRepository _orderRepository;
    private readonly IPaymentPipeline _paymentPipeline;
    private readonly IOrderValidator _orderValidator;
    public OrderService(
        ISendEmail notificationService,
        IOrderRepository orderRepository,
        IPaymentPipeline paymentPipeline,
        IOrderValidator orderValidator)
    {
        _notificationService = notificationService;
        _orderRepository = orderRepository;
        _paymentPipeline = paymentPipeline;
        _orderValidator = orderValidator;
    }
    public async Task ProcessOrderAsync(Order order)
    {
        _orderValidator.ValidateCustomerOrder(order);
        await _paymentPipeline.Execute(order.Total);
        _notificationService.SendingEmailToCustomer(order);
        _orderRepository.Save(order);
    }
}