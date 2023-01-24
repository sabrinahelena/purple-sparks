namespace PurpleSparks.Domain.Entities.OrdersModel
{
    public class StockModel
    {
        public int Id { get; set; }
        public List<HamburguerModel>? Hamburguer { get; set; }
        public List<FriesModel>? Fries { get; set; }
        public List<MilkshakeModel>? Milkshake { get; set; }
        public List<DrinkModel>? Drink { get; set; }
    }
}
