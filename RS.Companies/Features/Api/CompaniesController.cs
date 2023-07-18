using Microsoft.AspNetCore.Mvc;

namespace RS.Companies.Features.Api;

[Route("api/[controller]")]
[ApiController]
public class CompaniesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMany()
    {
        return NotFound();
    }

    [HttpGet("companyId:guid")]
    public IActionResult GetOne([FromRoute] Guid companyId)
    {
        return NotFound();
    }
}