using SolidOrderProcessor.Models;
using SolidOrderProcessor.Persistence;
namespace SolidOrderProcessor.Notification;

public class NotificationService : ISendEmail
{
    private readonly ILogger _logger;
    public NotificationService(ILogger logger)
    {
        _logger = logger;
    }
    public void SendingEmailToCustomer(Order order)
    {
        if (order.CustomerEmail is not null)
        {
            _logger.Log($"Email sent to {order.CustomerEmail}");
        }
        else
        {
            _logger.Log("Customer has no email.");
        }
    }
}