namespace Tree.Infrastructure.Persistence;

public record DatabaseSettings
{
    public string ConnectionString { get; init; } = string.Empty;
}