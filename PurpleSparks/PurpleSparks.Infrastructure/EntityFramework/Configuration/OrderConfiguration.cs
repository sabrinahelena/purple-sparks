using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PurpleSparks.Domain.Entities.OrdersModel;

namespace PurpleSparks.Infrastructure.EntityFramework.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderModel>
    {
        public void Configure(EntityTypeBuilder<OrderModel> builder)
        {
            builder.HasKey(x => x.Uid);
            builder.Property(x => x.Order).IsRequired();
            builder.Property(x => x.OrderedFries).IsRequired();
            builder.Property(x => x.OrderedDrink).IsRequired();
            builder.Property(x => x.OrderedHamburguer).IsRequired();
            builder.Property(x => x.OrderedMilkshake).IsRequired();
            builder.Property(x => x.Hamburguer);
            builder.Property(x => x.Fries);
            builder.Property(x => x.Milkshake);
            builder.Property(x => x.Drink);
        }
    }
}
