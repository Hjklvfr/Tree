namespace Tree.Application.Journal.Models;

public class GetSingleResponse
{
    public string Text { get; init; } = default!;
    public int Id { get; init; }
    public int EventId { get; init; }
    public DateTime CreatedAt { get; init; }
}