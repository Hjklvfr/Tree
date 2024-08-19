using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using Tree.Application.Common;
using Tree.Application.Journal.Models;

namespace Tree.Host.Controllers.Journal;

/// <summary>
/// Represents journal API
/// </summary>
public class JournalController : BaseApiController
{
    /// <summary>
    /// Get journal ranges
    /// </summary>
    /// <param name="pageNumber"></param>
    /// <param name="pageSize"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    [HttpPost("/api.user.journal.getRange")]
    public async Task<PaginatedResponse<Item>> GetRange(int pageNumber, int pageSize, JournalFilter filter)
    {
        return new PaginatedResponse<Item>(0, 0,
            new List<Item> { new() { Id = 1, EventId = 1, CreatedAt = DateTime.Now } });
    }
    
    /// <summary>
    /// Returns the information about an particular event by ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpPost("/api.user.journal.getSingle")]
    public async Task<GetSingleResponse> GetSingle(int id)
    {
        return new GetSingleResponse()
        {
            Id = id,
            CreatedAt = DateTime.Now,
            EventId = 1,
            Text = "text"
        };
    }
}