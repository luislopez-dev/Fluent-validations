﻿using FluentValidation;

namespace API.Extensions;

public static class FluentValidationExtensions
{
    public static IRuleBuilderOptions<T, string> FullName<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .MinimumLength(10)
            .Must(val => val.Split(" ").Length >= 2);
    }
}