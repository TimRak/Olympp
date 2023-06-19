using Real_Estate_Broker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Real_Estate_Broker.Infrastructure.DBContexts
{
    
    public class RealEstateContext : DbContext
    {
        public RealEstateContext(DbContextOptions<RealEstateContext> options) : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }

}
