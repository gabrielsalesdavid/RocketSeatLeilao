using Microsoft.AspNetCore.SignalR;
using RocketSeatAuction.API.Communication.Requests;
using RocketSeatAuction.API.Repositories;
using RocketSeatAuction.API.Services;

namespace RocketSeatAuction.API.UseCases.Auctions.Offers.CreateOffer;

public class CreateOfferUserCase
{

    public CreateOfferUserCase(LoggedUser loggedUser) => _loggedUser = loggedUser;
    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new RocketSeatAuctionDbContext();
        var loggedUser = _loggedUser.User();
        var offer = new Offer();
        {

            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };
        repository.Offers.Add(Offer);

        repository.SaveChanges();
        return offer.Id;
    }
}
