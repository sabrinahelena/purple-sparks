using Microsoft.EntityFrameworkCore;
using PurpleSparks.Domain.Entities.OrdersModel;
using PurpleSparks.Domain.Entities.OrdersModel.Foods;
using PurpleSparks.Infrastructure.EntityFramework.Configuration;
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
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new HamburguerConfiguration());
            builder.ApplyConfiguration(new DrinkConfiguration());
            builder.ApplyConfiguration(new FriesConfiguration());
            builder.ApplyConfiguration(new MilkshakeConfiguration());
            builder.ApplyConfiguration(new StockConfiguration());
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PurpleSparks;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<HamburguerModel> Hamburguers { get; set; }
        public DbSet<MilkshakeModel> Milkshakes { get; set; }
        public DbSet<DrinkModel> Drinks { get; set; }
        public DbSet<FriesModel> Fries { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<StockModel> Stocks { get; set; }
    }
}
