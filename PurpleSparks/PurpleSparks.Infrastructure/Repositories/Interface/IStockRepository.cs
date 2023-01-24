using PurpleSparks.Domain.Entities.OrdersModel;

namespace PurpleSparks.Infrastructure.Repositories.Interface
{
    public interface IStockRepository
    {
        List<StockModel> GetAll();
        StockModel GetById(Guid id);
        void InsertOrder(StockModel order);
        void UpdateOrder(StockModel order);
        void DeleteOrder(StockModel order);
    }
}
