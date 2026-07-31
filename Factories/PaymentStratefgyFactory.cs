using SolidOrderProcessor.Models;
using SolidOrderProcessor.Payments;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Factories;

public class PaymentStrategyFactory : IPaymentStrategyFactory
{
    private readonly IEnumerable<IPaymentStrategy> _strategies;

    public PaymentStrategyFactory(IEnumerable<IPaymentStrategy> strategies)
    {
        _strategies = strategies;
    }

    public IPaymentStrategy Create(PaymentMethod? paymentMethod)
    {
        return _strategies.First(strategy =>
            strategy.SupportedPaymentMethod == paymentMethod);
    }
}

