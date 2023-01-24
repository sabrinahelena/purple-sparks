using PurpleSparks.Domain.Entities.OrdersModel.Enums;

namespace PurpleSparks.Domain.Entities.OrdersModel.Foods
{
    public class DrinkModel : FoodModel
    {
        public DrinkEnum DrinkType { get; set; }
        public virtual StockModel Stock { get; set; }

    }
}
