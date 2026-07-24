using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Logging;

public interface ILogger
{
    void Log(string message);
}
