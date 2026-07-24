using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Validation;

public class OrderValidation : IOrderValidator
{
    public void ValidateCustomerOrder(Order order)
    {
        if (order is null)
        {
            throw new Exception("Order is null");
        }

        if (order.Total <= 0)
        {
            throw new Exception("Invalid total");
        }

    }
}
