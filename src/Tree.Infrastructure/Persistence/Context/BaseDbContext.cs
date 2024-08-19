using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Tree.Infrastructure.Persistence.Context;

public class BaseDbContext : DbContext
{
    protected BaseDbContext(IOptions<DatabaseSettings> dbSettings)
    {
        _dbSettings = dbSettings.Value;
    }

    private readonly DatabaseSettings _dbSettings;
    
    public IDbConnection Connection => Database.GetDbConnection();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseDatabase(_dbSettings.ConnectionString);
    }
}