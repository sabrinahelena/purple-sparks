using PurpleSparks.Domain.Entities.OrdersModel;

namespace PurpleSparks.Infrastructure.Repositories.Interface
{
    public interface IOrderRepository
    {
        List<OrderModel> GetAll();
        OrderModel GetById(Guid id);
        void InsertOrder(OrderModel order);
        void UpdateOrder(OrderModel order);
        void DeleteOrder(OrderModel order);
    }
}
