using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Services;

public class OrderService
{
    public void ProcessOrder(Order order)
    {
        // Validation
        if (order == null)
        {
            throw new Exception("Order is null");
        }

        if (order.Total <= 0)
        {
            throw new Exception("Invalid total");
        }

        // Payment
        if (order.PaymentMethod == PaymentMethod.CreditCard)
        {
            Console.WriteLine("Paid with credit card");
        }
        else if (order.PaymentMethod == PaymentMethod.PayPal)
        {
            Console.WriteLine("Paid with PayPal");
        }
        else
        {
            throw new Exception("Unknown payment method");
        }

        // Notification
        if (order.CustomerEmail != null)
        {
            Console.WriteLine($"Email sent to {order.CustomerEmail}");
        }

        // Persistence
        File.AppendAllText(
            "orders.txt",
            order.Id + Environment.NewLine);
    }
}