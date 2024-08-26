using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bukify.Infrastructure;

public class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
    }
}
