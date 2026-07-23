using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Notification;

public interface ISendEmail
{
    public void SendingEmailToCustomer(Order order);
}


