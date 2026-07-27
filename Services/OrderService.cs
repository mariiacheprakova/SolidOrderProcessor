using SolidOrderProcessor.Models;
using SolidOrderProcessor.Notification;
using SolidOrderProcessor.Payments;
using SolidOrderProcessor.Persistence;
using SolidOrderProcessor.Validation;

namespace SolidOrderProcessor.Services;

public class OrderService
{
    private readonly ISendEmail _notificationService;
    private readonly IOrderRepository _orderRepository;
    private readonly PaymentPipeline _paymentPipeline;
    private readonly IOrderValidator _orderValidator;

    public OrderService(
        ISendEmail notificationService,
        IOrderRepository orderRepository,
        PaymentPipeline paymentPipeline,
        IOrderValidator orderValidator)
    {
        _notificationService = notificationService;
        _orderRepository = orderRepository;
        _paymentPipeline = paymentPipeline;
        _orderValidator = orderValidator;
    }

    public async Task ProcessOrder(Order order)
    {
        _orderValidator.ValidateCustomerOrder(order);
        await _paymentPipeline.Execute(order.Total);
        _notificationService.SendingEmailToCustomer(order);
        _orderRepository.Save(order);
    }
}