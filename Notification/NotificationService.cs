using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Notification;

public class NotificationService : ISendEmail
{
    public void SendEmailToCustomer(Order order) =>
    order.CustomerEmail is not null
        ? Console.WriteLine($"Email sent to {order.CustomerEmail}")
        : Console.WriteLine("Customer has no email.");
}
