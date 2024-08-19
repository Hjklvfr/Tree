using Microsoft.AspNetCore.Mvc;

namespace Tree.Host.Controllers.Tree;

public class NodeController : BaseApiController
{
    [HttpPost("/api.user.tree.node.create")]
    public async Task Create(string treeName, int parentNodeId, string nodeName)
    {
    }
    
    [HttpPost("/api.user.tree.node.delete")]
    public async Task Delete(string treeName, int nodeId)
    {
    }
    
    [HttpPost("/api.user.tree.node.rename")]
    public async Task Rename(string treeName, int nodeId, string newNodeName)
    {
    }
}