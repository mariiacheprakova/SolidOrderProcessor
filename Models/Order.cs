
using SolidOrderProcessor.Models;
namespace SolidOrderProcessor.Models;

public class Order
{
    public int Id { set; get; }
    public decimal Total { set; get; }
    public PaymentMethod? PaymentMethod { set; get; }
    public string? CustomerEmail { set; get; }

}

