namespace Tree.Application.Tree;

public class Node
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public ICollection<Node> Children { get; set; } = new List<Node>();
}