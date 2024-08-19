namespace Tree.Application.Common;

public record PaginatedResponse<T>
{
    public List<T> Items { get; init; } = Array.Empty<T>().ToList();
    public int Skip { get; init; }
    public int Count { get; init; }

    public PaginatedResponse(int skip, int count, List<T> items)
    {
        Skip = skip;
        Count = count;
        Items = items;
    }
}