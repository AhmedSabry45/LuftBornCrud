﻿using Application.Extension.ApplicationExtensionDI;
using FluentValidation;
using FluentValidation.AspNetCore;
using LuftBornCodeTest.Extensions.ExceptionFilter;
using System.Text.Json.Serialization;

namespace LuftBornCodeTest.Extensions
{
    public static class AddControllerWithFluentValidationDIExtension
    {
        public static IServiceCollection AddControllerWithFluentValidation(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                //options.Filters.Add(typeof(ExceptionActionFilter));
            })
            .ConfigureApiBehaviorOptions(options => options.InvalidModelStateResponseFactory = context => context.HandleInvalidRequest())
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
           

            services.AddValidatorsFromAssembly(typeof(DependanciesExtension).Assembly);
            services.AddFluentValidationAutoValidation(options =>
            {
                ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;
                ValidatorOptions.Global.DefaultRuleLevelCascadeMode = CascadeMode.Stop;
            });

            return services;
        }
    }

}
