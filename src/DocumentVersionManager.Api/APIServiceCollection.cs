﻿using Asp.Versioning;
using DocumentVersionManager.Domain.Utils;
using DocumentVersionManager.Infrastructure.GlobalExceptionHandler;
using DocumentVersionManager.Infrastructure.Persistence;
using DocumentVersionManager.Infrastructure.Utils;
using LanguageExt.TypeClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Api;

public static class APIServiceCollection
{
    public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
    {

        var applicationAssembly = typeof(APIServiceCollection).Assembly;
        services.AddAutoMapper(applicationAssembly);
        services.AddExceptionHandler<GlobalExceptionHandler>();
        //services.AddExceptionHandler<GlobalExceptionHandler.GlobalExceptionHandler>();
        services.AddProblemDetails();
        services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<Program>());

        services.AddCors();
        services.AddApiVersioning(
            option =>
            {
                option.ReportApiVersions = true;
                option.AssumeDefaultVersionWhenUnspecified = true;
                option.DefaultApiVersion = new ApiVersion(2, 0);
                option.ApiVersionReader = ApiVersionReader.Combine(
                    new QueryStringApiVersionReader("api-version"),
                    new HeaderApiVersionReader("api-version"),
                    new MediaTypeApiVersionReader("version")
                    );


            });

        // services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<Program>());
        return services;
    }
    public static IServiceCollection AddHealthChecks(this IServiceCollection services, IConfiguration configuration)
    {
        var hcBuilder = services.AddHealthChecks();

        hcBuilder.AddCheck("self", () => HealthCheckResult.Healthy());
        //hcBuilder.AddSqlServer(configuration["ConnectionStrings:Default"]);

        return services;
    }



}




