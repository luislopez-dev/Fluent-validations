using API.Models;
using FluentValidation;

namespace API.Validations;

public class ProductValidator: AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(model => model.Name).NotEmpty();
    }
}