using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.Communication.Requests;

namespace RocketSeatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]
public class OfferController : RocketSeatAuctionBaseControllerController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
    {
        return Created();
    }
}
