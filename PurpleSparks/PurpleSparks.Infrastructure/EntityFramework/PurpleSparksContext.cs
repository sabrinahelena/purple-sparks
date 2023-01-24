using Microsoft.EntityFrameworkCore;
using PurpleSparks.Domain.Entities.OrdersModel;
using PurpleSparks.Domain.Entities.OrdersModel.Foods;
using System.Reflection;

namespace PurpleSparks.Infrastructure.EntityFramework
{
    public class PurpleSparksContext : DbContext
    {
        public PurpleSparksContext(DbContextOptions<PurpleSparksContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);

        }

        public DbSet<HamburguerModel> Hamburguers { get; set; }
        public DbSet<MilkshakeModel> Milkshakes { get; set; }
        public DbSet<DrinkModel> Drinks { get; set; }
        public DbSet<FriesModel> Fries { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<StockModel> Stocks { get; set; }
    }
}
