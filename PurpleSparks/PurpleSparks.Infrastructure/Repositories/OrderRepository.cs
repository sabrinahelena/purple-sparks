using PurpleSparks.Domain.Entities.OrdersModel;
using PurpleSparks.Infrastructure.EntityFramework;

namespace PurpleSparks.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<OrderModel>
    {
        public OrderRepository(PurpleSparksContext context) : base(context)
        {
        }
    }
}
