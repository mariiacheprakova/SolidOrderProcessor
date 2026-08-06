using SolidOrderProcessor.Models;

namespace SolidOrderProcessor.Validation;
public interface IOrderValidator
{
    public void ValidateCustomerOrder(Order order);
}
