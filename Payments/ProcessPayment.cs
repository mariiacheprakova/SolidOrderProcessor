
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Payments;

    public class ProcessPayment 
    {
    public void ProcessingPayment(Order order)
    {
        IPaymentProcessor processor = order.PaymentMethod switch
        {
            PaymentMethod.PayPal => new PayPalProcessor(),
            PaymentMethod.CreditCard => new CreditCardProcessor(),
            _ => throw new InvalidOperationException()
        };

        processor.PaymentMethod(order);
         
    }

        
    }

