using Microsoft.AspNetCore.Mvc;
using Tree.Application.Tree;

namespace Tree.Host.Controllers.Tree;

public class TreeController : BaseApiController
{
    [HttpPost("/api.user.tree.get")]
    public async Task<Node> Get(string treeName)
    {
        return new Node
        {
            Id = 123,
            Name = "123",
            Children = new List<Node>
            {
                new Node
                {
                    Id = 124,
                    Name = "124"
                }
            }
        };
    }
}