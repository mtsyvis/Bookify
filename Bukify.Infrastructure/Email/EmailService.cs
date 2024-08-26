using Bookify.Application.Abstractions.Email;

namespace Bukify.Infrastructure.Email;

public class EmailService : IEmailService
{
    public Task SendAsync(Bookify.Domain.Users.Email recipient, string subject, string body)
    {
        throw new NotImplementedException();
    }
}
