using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Persistence;

public interface ILogger
{
    void Log(string message);
}
