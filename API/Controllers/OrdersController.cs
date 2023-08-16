using API.Data;
using API.Models;
using API.Validations;
using FluentValidation;
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

    // Modifying default fluent validations behavior
    [HttpPost]
    public ActionResult Post([FromBody] Order order)
    {
        var product = new Product()
        {
            Name = null
        };
        var validationResult = new ProductValidator().Validate(product);

        return validationResult.IsValid
            ? (ActionResult)Ok("Success!")
            : BadRequest("Validation Failed");
    }
    
    // Modifying default fluent validations behavior
    [HttpPost]
    public ActionResult ThrowExep([FromBody] Order order)
    {
        var product = new Product()
        {
            Name = null
        };
        new ProductValidator().ValidateAndThrow(product);
        return Ok("Success!");
    }

}