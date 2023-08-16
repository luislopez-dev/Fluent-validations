using API.Models;
using FluentValidation;

namespace API.Validations;

public class OrderValidator : AbstractValidator<Order>
{
    public OrderValidator()
    {
        // Rules for CustomerName field
        RuleFor(model => model.CustomerName).NotNull();
        RuleFor(model => model.CustomerName).NotEmpty();
        RuleFor(model => model.CustomerName).MaximumLength(10);
        RuleFor(model => model.CustomerName).MinimumLength(5);
        
        // Rules for Price field
        RuleFor(model => model.Price).InclusiveBetween(500, 1500);
        
        

    } 
}