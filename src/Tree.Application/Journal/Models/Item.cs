namespace Tree.Application.Journal.Models;

public record Item
{
    public int Id { get; init; }
    public int EventId { get; init; }
    public DateTime CreatedAt { get; init; }
}