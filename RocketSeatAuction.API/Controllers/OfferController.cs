using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.Communication.Requests;
using RocketSeatAuction.API.Filters;
using RocketSeatAuction.API.UseCases.Auctions.Offers.CreateOffer;

namespace RocketSeatAuction.API.Controllers;

[Route("[controller]")]
[ApiController]


[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketSeatAuctionBaseControllerController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId, 
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUserCase useCase)
    {
        var id = useCase.Execute(itemId, request);
        useCase.Execute(itemId, request);
        var useCase = new CreateOfferUseCase();
        return Created(string.Empty, id);
    }
}
