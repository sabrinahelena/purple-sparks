using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PurpleSparks.Domain.Entities.OrdersModel;
using PurpleSparks.Domain.Entities.OrdersModel.Foods;

namespace PurpleSparks.Infrastructure.EntityFramework.Configuration
{
    public class HamburguerConfiguration : IEntityTypeConfiguration<HamburguerModel>
    {
        public void Configure(EntityTypeBuilder<HamburguerModel> builder)
        {
            builder.HasKey(x => x.Uid);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.HamburguerType).IsRequired();


            builder.HasOne(stock => stock.Stock)
                .WithMany(hamburguers => hamburguers.Hamburguers);
        }
    }
}
