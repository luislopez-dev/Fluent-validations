using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController: ControllerBase
{
    private readonly FakeDataStore _dataStore;

    public OrdersController(FakeDataStore dataStore)
    {
        _dataStore = dataStore;
    }

    [HttpPost]
    public async Task<ActionResult> AddOrder([FromBody] Order order)
    {
        await _dataStore.AddOrder(order);
        return StatusCode(201);
    }

    [HttpGet]
    public async Task<ActionResult> GetProducts()
    {
        var orders = await _dataStore.GetOrders();
        return Ok(orders);
    }
}