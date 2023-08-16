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
        
        // Rules for Price Field
        RuleFor(model => model.Price).InclusiveBetween(500, 1500);
        
        // Rules for CustomerEmail field
        /*
         * This email validator validates the customer email address
         * against built in regular expressions which cover most of the
         * email address formats. The next validator (the chaining validator)
         * ensures the email address is at least 20 characters
         */
        RuleFor(model => model.CustomerEmail)
            .EmailAddress()
            .MinimumLength(20);
        
        // Rules for OrderStatus field
        /*
         * This validator will ensure that the value
         * is one of the included members of the enum
         */ 
        RuleFor(model => model.OrderStatus).IsInEnum();
    } 
}