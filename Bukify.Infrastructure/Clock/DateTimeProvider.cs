using Bookify.Application.Abstractions.Clock;

namespace Bukify.Infrastructure.Clock;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => throw new NotImplementedException();
}
