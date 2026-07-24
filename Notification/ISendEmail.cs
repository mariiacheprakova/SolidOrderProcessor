using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Models;
namespace SolidOrderProcessor.Notification;

public interface ISendEmail
{
    public void SendingEmailToCustomer(Order order);
}


