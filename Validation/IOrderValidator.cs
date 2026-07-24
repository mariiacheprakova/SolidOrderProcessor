using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Validation;

public interface IOrderValidator
{
    public void ValidateCustomerOrder(Order order);
}
