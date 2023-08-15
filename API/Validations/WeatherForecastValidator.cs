using FluentValidation;

namespace API.Validations;

public class WeatherForecastValidator : AbstractValidator<WeatherForecast>
{
    public WeatherForecastValidator()
    {
        RuleFor(model => model.TemperatureC).LessThanOrEqualTo(100);
    }
}