using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Validation;

public interface IOrderValidator
{
    public void ValidateCustomerOrder(Order order);
}
