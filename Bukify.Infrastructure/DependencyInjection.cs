using Bookify.Application.Abstractions.Clock;
using Bookify.Application.Abstractions.Email;
using Bukify.Infrastructure.Clock;
using Bukify.Infrastructure.Email;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bukify.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDateTimeProvider, DateTimeProvider>();
        services.AddTransient<IEmailService, EmailService>();

        var connectionString = configuration.GetConnectionString("Database")
            ?? throw new InvalidOperationException("Database connection string is missing");

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        });


        return services;
    }
}
