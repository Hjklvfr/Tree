using Microsoft.AspNetCore.Mvc;

namespace Tree.Host.Controllers.Partner;

public class PartnerController : BaseApiController
{
    [HttpPost("/api.user.partner.rememberMe")]
    public async Task RememberMe(string code)
    {
    }
}