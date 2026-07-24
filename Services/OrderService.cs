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
    private readonly PaymentService _paymentService;
    private readonly IOrderValidator _orderValidator;

    public OrderService(
        ISendEmail notificationService,
        IOrderRepository orderRepository,
        PaymentService paymentService,
        IOrderValidator orderValidator)
    {
        _notificationService = notificationService;
        _orderRepository = orderRepository;
        _paymentService = paymentService;
        _orderValidator = orderValidator;
    }

    public void ProcessOrder(Order order)
    {
        _orderValidator.ValidateCustomerOrder(order);
        _paymentService.ProcessPayment(order);
        _notificationService.SendingEmailToCustomer(order);
        _orderRepository.Save(order);
    }
}