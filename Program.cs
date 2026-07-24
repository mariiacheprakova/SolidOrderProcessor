using SolidOrderProcessor;
using SolidOrderProcessor.Models;
using SolidOrderProcessor.Notification;
using SolidOrderProcessor.Payments;
using SolidOrderProcessor.Persistence;
using SolidOrderProcessor.Services;
using SolidOrderProcessor.Validation;
using SolidOrderProcessor.Logging;


var logger = new ConsoleLogger();

var validator = new OrderValidation();
var notificationService = new NotificationService(logger);
var repository = new FileOrderRepository();

IEnumerable<IPaymentStrategy> strategies =
[
    new CreditCardPayment(logger),
    new PayPalPayment(logger)
];

var paymentService = new PaymentService(strategies);

var orderService = new OrderService(
    notificationService,
    repository,
    paymentService,
    validator);

//BAD LSP EXAMPLE
PaymentProcessor processor = new RevolutProcessor(logger);
processor.ProcessPayment();   // Works

processor = new BrokenPaymentProcessor(logger);
processor.ProcessPayment();   // Throws NotSupportedException



Order order = new Order
{
    Id = 1,
    Total = 100,
    CustomerEmail = "customer@example.com",
    PaymentMethod = PaymentMethod.PayPal
};

orderService.ProcessOrder(order);