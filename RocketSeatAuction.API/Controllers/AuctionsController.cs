using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketSeatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketSeatAuction.API.Controllers;
/*
[Route("[controller]")]
[ApiController]
*/
public class AuctionsController : RocketSeatAuctionBaseControllerController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200Ok))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();
        var result = useCase.Execute();
        var item = result.Items.First();

        result.Name.Trim();

        if (item.Condition == Enums.Condition.NEW)
            throw new Exception();

        if (result is null)
            return NoContent();

        return Ok(result);
    }
}