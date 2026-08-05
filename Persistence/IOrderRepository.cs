using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Persistence;
public interface IOrderRepository
{
    public void Save(Order order);
}
