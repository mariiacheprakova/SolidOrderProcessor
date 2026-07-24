using SolidOrderProcessor.Models;
using SolidOrderProcessor.Notification;
using SolidOrderProcessor.Payments;
using SolidOrderProcessor.Persistence;
using SolidOrderProcessor.Services;
using SolidOrderProcessor.Validation;

ILogger logger = new ConsoleLogger();

IOrderValidator validator = new OrderValidation();
ISendEmail notificationService = new NotificationService();
IOrderRepository repository = new FileOrderRepository();

IEnumerable<IPaymentProcessor> processors =
[
    new CreditCardProcessor(logger),
    new PayPalProcessor(logger)
];

PaymentService paymentService = new PaymentService(processors);

OrderService orderService = new OrderService(
    notificationService,
    repository,
    paymentService,
    validator);

Order order = new Order
{
    Id = 1,
    Total = 100,
    CustomerEmail = "customer@example.com",
    PaymentMethod = PaymentMethod.PayPal
};

orderService.ProcessOrder(order);