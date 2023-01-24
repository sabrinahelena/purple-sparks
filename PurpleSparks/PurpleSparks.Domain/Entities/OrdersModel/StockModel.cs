using PurpleSparks.Domain.Entities.Base;
using PurpleSparks.Domain.Entities.OrdersModel.Foods;

namespace PurpleSparks.Domain.Entities.OrdersModel
{
    public class StockModel : Entity
    {
        public List<HamburguerModel>? Hamburguers { get; set; }
        public List<FriesModel>? Fries { get; set; }
        public List<MilkshakeModel>? Milkshakes { get; set; }
        public List<DrinkModel>? Drinks { get; set; }
    }
}
