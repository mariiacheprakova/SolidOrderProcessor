using SolidOrderProcessor;
using SolidOrderProcessor.Models;
using SolidOrderProcessor.Notification;
using SolidOrderProcessor.Payments;
using SolidOrderProcessor.Persistence;
using SolidOrderProcessor.Services;
using SolidOrderProcessor.Validation;

ILogger logger = new ConsoleLogger();

IOrderValidator validator = new OrderValidation();
ISendEmail notificationService = new NotificationService(logger);
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