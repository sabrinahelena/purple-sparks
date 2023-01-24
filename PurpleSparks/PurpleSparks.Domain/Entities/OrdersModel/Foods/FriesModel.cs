using PurpleSparks.Domain.Entities.OrdersModel.Enums;

namespace PurpleSparks.Domain.Entities.OrdersModel.Foods
{
    public class FriesModel : FoodModel
    {
        public FriesEnum FriesType { get; set; }
        public virtual StockModel Stock { get; set; }

    }
}
