using RocketSeatAuction.API.Entities;
using MicrosoftEntityFrameworkCore;

namespace RocketSeatAuction.API.Repositories;

public class RocketSeatAuctionDbContext : DbContext { 
    public DbSet<Auction> Ations { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:\\Workspace\\leilaoDbNLW.db");
    }
}
