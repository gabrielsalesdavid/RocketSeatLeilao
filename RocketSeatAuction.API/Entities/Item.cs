namespace RocketSeatAuction.API.Entities;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string brand { get; set; }
    public int Condition { get; set; }
    public decimal BasePrice { get; set; }
    public int Auction { get; set; }

}
