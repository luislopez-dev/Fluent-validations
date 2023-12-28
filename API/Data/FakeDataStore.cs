 /*
 * Author: Luis López
 * Website: https://github.com/luislopez-dev
 * Description: Training Project
 */
 
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Data;

public class FakeDataStore
{
    private static List<Order> _orders;

    public FakeDataStore()
    {
        _orders = new List<Order>()
        {
        };
    }

    public async Task AddOrder(Order order)
    {
        _orders.Add(order);
        await Task.CompletedTask;
    }

    public async Task<IEnumerable<Order>> GetOrders()
    {
        return await Task.FromResult(_orders);
    }
}