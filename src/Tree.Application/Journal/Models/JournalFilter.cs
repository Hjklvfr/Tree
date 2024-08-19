namespace Tree.Application.Journal.Models;

public record JournalFilter
{
    public DateTime From { get; init; }
    public DateTime To { get; init; }
    public string Search { get; init; } = default!;
}