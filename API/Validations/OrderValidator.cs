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
        
        // Rules for Customer Email
        /*
         * This email validator validates the customer email address
         * against built in regular expressions which cover most of the
         * email address formats
         */
        RuleFor(model => model.CustomerEmail).EmailAddress();

    } 
}