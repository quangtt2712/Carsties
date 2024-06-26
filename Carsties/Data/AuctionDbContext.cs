using Carsties.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carsties.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }

    }
}
