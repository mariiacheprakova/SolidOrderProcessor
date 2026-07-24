using System;
using System.Collections.Generic;
using System.Text;
using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Persistence;

public interface IOrderRepository
{
    public void Save(Order order);
}
