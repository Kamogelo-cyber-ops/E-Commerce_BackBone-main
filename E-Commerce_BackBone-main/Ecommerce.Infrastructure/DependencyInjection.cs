using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // SQLite connection string (creates a file named Ecommerce.db)
        var localConnectionString = "Data Source=../Ecommerce.Api/Ecommerce.db";

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(localConnectionString)); 

        return services;
    }
}