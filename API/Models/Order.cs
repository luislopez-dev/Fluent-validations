using API.Enums;

namespace API.Models;

public class Order
{
    public string Name { get; set; }
    public int Priice { get; set; }
    public string CustomerEmail { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public Product Product { get; set; }
}