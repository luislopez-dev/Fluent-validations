using API;
using API.Validations;
using FluentValidation.TestHelper;
using FluentValidation;

namespace UnitTests;

public class WeatherForecastValidatorTests
{
    private readonly WeatherForecastValidator _validator;

    public WeatherForecastValidatorTests(WeatherForecastValidator validator)
    {
        _validator = validator;
    }

    [Fact]
    public void GivenAnInvalidTemperatureCValue_ShouldHaveValidationError()
    {
        _validator.TestValidate(new WeatherForecast())
            .ShouldHaveValidationErrorFor(model => model.TemperatureC);
    }
}