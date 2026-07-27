using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Payments;

public interface IPaymentStep
{
    Task Handle(decimal amount, Func<Task> next);
}
