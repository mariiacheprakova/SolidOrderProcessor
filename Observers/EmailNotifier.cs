using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Logging;
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Observers;

public class EmailNotifier : IOrderObserver
{
    private readonly ILogger _logger;
    public EmailNotifier(ILogger logger) => _logger = logger;
    public void OnOrderPlaced(Order order) => _logger.Log("Mock email notification sent.");
    
}
