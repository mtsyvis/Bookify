using Bookify.Application.Abstractions.Clock;
using Bookify.Application.Abstractions.Email;
using Bukify.Infrastructure.Clock;
using Bukify.Infrastructure.Email;
using Microsoft.Extensions.DependencyInjection;

namespace Bukify.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IDateTimeProvider, DateTimeProvider>();
        services.AddTransient<IEmailService, EmailService>();


        return services;
    }
}
