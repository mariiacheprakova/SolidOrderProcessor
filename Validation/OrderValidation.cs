using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SolidOrderProcessor.Validation;

public class OrderValidation : IOrderValidator
{
    public bool ValidateCustomerOrder(Order order)
    {
        if(!order)
        {
            throw new Exception("Order is null");
        }

        if(order.Total <= 0)
        {
            throw new Exception("Invalid total");
        }

        return true;
    }
}
