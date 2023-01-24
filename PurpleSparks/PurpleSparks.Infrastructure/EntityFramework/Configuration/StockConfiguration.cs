using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PurpleSparks.Domain.Entities.OrdersModel;

namespace PurpleSparks.Infrastructure.EntityFramework.Configuration
{
    public class StockConfiguration : IEntityTypeConfiguration<StockModel>
    {
        public void Configure(EntityTypeBuilder<StockModel> builder)
        {
            builder.HasKey(x => x.Uid);
            builder.Property(x => x.Hamburguers);
            builder.Property(x => x.Milkshakes);
            builder.Property(x => x.Drinks);
            builder.Property(x => x.Fries);
        }
    }
}
