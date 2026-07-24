using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Notification;

public class NotificationService : ISendEmail
{
    public void SendingEmailToCustomer(Order order)
    {
        if (order.CustomerEmail is not null)
        {
            Console.WriteLine($"Email sent to {order.CustomerEmail}");
        }
        else
        {
            Console.WriteLine("Customer has no email.");
        }
    }
}