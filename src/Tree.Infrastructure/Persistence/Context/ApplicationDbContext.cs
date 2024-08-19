using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Tree.Infrastructure.Persistence.Context;

public class ApplicationDbContext : BaseDbContext
{
    protected ApplicationDbContext(IOptions<DatabaseSettings> dbSettings) : base(dbSettings)
    {
    }
}