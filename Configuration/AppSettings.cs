
namespace SolidOrderProcessor.Configuration;

public sealed class AppSettings
{
    private static readonly AppSettings _instance = new AppSettings();

    private AppSettings()
    {
        Environment = "Development";
        EnablePaymentLogging = true;
    }

    public static AppSettings Instance => _instance;
    public string Environment { get; }
    public bool EnablePaymentLogging { get; }
    
}
