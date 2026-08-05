using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Persistence;
public class FileOrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        File.AppendAllText("orders.txt", order.Id + Environment.NewLine);
    }
}