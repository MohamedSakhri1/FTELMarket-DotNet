
using FTELMarket.Api.Models;
using FTELMarket.Api.Repositories;

namespace FTELMarket.Api.Extensions;

public static class ProgramServiceExtension
{
    public static void AddDependecyInjectionScoped(this IServiceCollection service)
    {
        service.AddScoped<IRepository<Product>, PostgresRepository<Product>>();
        service.AddScoped<IRepository<Category>, PostgresRepository<Category>>();
    }
}