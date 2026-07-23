namespace SolidOrderProcessor.Payments;

    public class CreditCardProcesser : IPaymentProcessor
    {
        public void PaymentMethod(Order order) => Console.WriteLine("Paid with credit card");
  
    }

 