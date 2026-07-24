using SolidOrderProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrderProcessor.Persistence;

public class FileOrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        File.AppendAllText("orders.txt", order.Id + Environment.NewLine);
    }
}