using SolidOrderProcessor;
using SolidOrderProcessor.Configuration;
using SolidOrderProcessor.Facades;
using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;
using SolidOrderProcessor.Notification;
using SolidOrderProcessor.Observers;
using SolidOrderProcessor.Payments;
using SolidOrderProcessor.Persistence;
using SolidOrderProcessor.Services;
using SolidOrderProcessor.Validation;


var logger = new ConsoleLogger();

var validator = new OrderValidation();
var notificationService = new NotificationService(logger);
var repository = new FileOrderRepository();

IPaymentStrategy creditCardStrategy =
    new CreditCardPayment(logger);

IPaymentStrategy payPalStrategy =
    new PayPalPayment(logger);

IPaymentStrategy bankTransferStrategy =
    new BankTransferPayment(logger);

if (AppSettings.Instance.EnablePaymentLogging)
{
    payPalStrategy =
        new PaymentLoggingDecorator(
            payPalStrategy,
            logger);
}

payPalStrategy =
    new PaymentTimingDecorator(
        logger,
        payPalStrategy);


IEnumerable<IPaymentStrategy> strategies =
[
    creditCardStrategy,
    payPalStrategy,
    bankTransferStrategy
];

var paymentService = new PaymentService(strategies);

var orderService = new OrderService(
    notificationService,
    repository,
    paymentService,
    validator);

var eventPublisher = new OrderEventPublisher();
eventPublisher.Subscribe(new EmailNotifier(logger));
eventPublisher.Subscribe(new AuditLogger(logger));


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
var OrderFacade = new OrderFacade(orderService,eventPublisher);
OrderFacade.PlaceOrder(order);