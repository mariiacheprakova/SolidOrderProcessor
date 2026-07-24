
using SolidOrderProcessor.Configuration;

namespace SolidOrderProcessor.Logging;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        if (AppSettings.Instance.EnablePaymentLogging)
        {
            Console.WriteLine(message);
        }
    }
}
