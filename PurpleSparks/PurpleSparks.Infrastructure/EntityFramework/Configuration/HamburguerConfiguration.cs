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
            builder.Property(x => x.Price);
            builder.Property(x => x.Quantity);
            builder.Property(x => x.HamburguerType);


            builder.HasOne(stock => stock.Stock)
                .WithMany(hamburguers => hamburguers.Hamburguer);
        }
    }
}
