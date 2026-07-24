using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Configuration;

public sealed class AppSettings
{
    private static readonly AppSettings _instance = new AppSettings();

    public static AppSettings Instance => _instance;

    private AppSettings()
    {
    }

    public string Environment { get; set; } = "Development";
    public bool EnablePaymentLogging { get; set; } = true;
}
