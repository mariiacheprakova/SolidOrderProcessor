using SolidOrderProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Observers;

public interface IOrderObserver
{
    void OnOrderPlaced(Order order);
}
