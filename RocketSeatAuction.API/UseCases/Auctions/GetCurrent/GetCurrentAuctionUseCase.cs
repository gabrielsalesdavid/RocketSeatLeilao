using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new RocketSeatAuctionDbContext();
        return repository.Auctions.First();        
    }
}
