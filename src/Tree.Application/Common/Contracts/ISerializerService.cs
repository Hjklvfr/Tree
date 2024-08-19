namespace Tree.Application.Common.Contracts;

public interface ISerializerService : ITransientService
{
    string Serialize<T>(T obj);

    T? Deserialize<T>(string text);
}