using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketSeatAuctionDbContext();

        var today = DateTime.Now;

        return repository.Auctions
                         .Include(auction => auction.Items)
                         .FirstOrDefault(Auction => today >= Auction.Starts && today <= Auction.Ends);        
    }
}
