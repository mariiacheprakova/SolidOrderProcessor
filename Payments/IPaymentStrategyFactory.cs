using SolidOrderProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Payments;

public interface IPaymentStrategyFactory
{
    IPaymentStrategy Create(PaymentMethod paymentMethod);
    
}
