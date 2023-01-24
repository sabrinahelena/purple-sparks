using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PurpleSparks.Domain.Entities.OrdersModel.Foods;

namespace PurpleSparks.Infrastructure.EntityFramework.Configuration
{
    public class MilkshakeConfiguration : IEntityTypeConfiguration<MilkshakeModel>
    {
        public void Configure(EntityTypeBuilder<MilkshakeModel> builder)
        {
            builder.HasKey(x => x.Uid);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.MilkshakeType).IsRequired();


            builder.HasOne(stock => stock.Stock)
                .WithMany(milkshakes => milkshakes.Milkshakes);
        }
    }
}
