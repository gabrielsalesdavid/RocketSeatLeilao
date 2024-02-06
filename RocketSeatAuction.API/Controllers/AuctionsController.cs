using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RocketSeatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]
public class AuctionsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction()
    {
        return Ok("Gabriel");
    }
    [HttpGet("test")]
    public IActionResult Test()
    {
        return NotFound("Gabriel");
    }
}
