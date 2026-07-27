using SolidOrderProcessor.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Payment;

public class PaymentValidationStep : IPaymentStep
{
    public async Task Handle(decimal amount, Func<Task> next)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Payment amount must be greater than zero.");
        }

        await next();
    }
}
