using PurpleSparks.Domain.Entities.OrdersModel;
using PurpleSparks.Infrastructure.EntityFramework;

namespace PurpleSparks.Infrastructure.Repositories
{
    public class StockRepository : BaseRepository<StockModel>
    {
        public StockRepository(PurpleSparksContext context) : base(context)
        {
        }
    }
}
