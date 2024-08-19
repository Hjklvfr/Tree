using System.Text.Json;
using Tree.Application.Common.Contracts;

namespace Tree.Infrastructure.Common.Services;

public class StandardSerializeService : ISerializerService
{
    private static readonly JsonSerializerOptions? DefaultSerializerOptions = new JsonSerializerOptions();
    
    public string Serialize<T>(T obj)
    {
        return JsonSerializer.Serialize<T>(obj, DefaultSerializerOptions);
    }

    public T? Deserialize<T>(string text)
    {
        return JsonSerializer.Deserialize<T>(text, DefaultSerializerOptions);
    }
}