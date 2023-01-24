using PurpleSparks.Domain.Entities.OrdersModel.Enums;

namespace PurpleSparks.Domain.Entities.OrdersModel.Foods
{
    public class MilkshakeModel : FoodModel
    {
        public MilkshakeEnum MilkshakeType { get; set; }
    }
}
