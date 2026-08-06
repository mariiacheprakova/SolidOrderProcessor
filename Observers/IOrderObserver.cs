using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Observers;
public interface IOrderObserver
{
    void OnOrderPlaced(Order order);
}
