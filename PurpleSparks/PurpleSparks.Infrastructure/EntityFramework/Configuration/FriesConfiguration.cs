using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PurpleSparks.Domain.Entities.OrdersModel.Foods;

namespace PurpleSparks.Infrastructure.EntityFramework.Configuration
{
    public class FriesConfiguration : IEntityTypeConfiguration<FriesModel>
    {
        public void Configure(EntityTypeBuilder<FriesModel> builder)
        {
            builder.HasKey(x => x.Uid);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.FriesType).IsRequired();


            builder.HasOne(stock => stock.Stock)
                .WithMany(fries => fries.Fries);
        }
    }
}
