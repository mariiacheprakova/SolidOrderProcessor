using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SolidOrderProcessor.Persistence;

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}
