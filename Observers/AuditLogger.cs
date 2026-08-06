using SolidOrderProcessor.Models;
using SolidOrderProcessor.Logging;

namespace SolidOrderProcessor.Observers;
public class AuditLogger : IOrderObserver
{
    private readonly ILogger _logger;
    public AuditLogger(ILogger logger) => _logger = logger;
    public void OnOrderPlaced(Order order) => _logger.Log("Mock audit record created.");
}
