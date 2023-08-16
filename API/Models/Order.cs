using API.Enums;

namespace API.Models;

public class Order
{
    public string CustomerName { get; set; }
    public int Price { get; set; }
    public string CustomerEmail { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public Product[] Products { get; set; }
}