﻿using PurpleSparks.Domain.Entities.OrdersModel.Enums;

namespace PurpleSparks.Domain.Entities.OrdersModel
{
    public class OrderModel
    {
        public int Id { get; set; }
        public OrderEnum Order { get; set; }
        public bool OrderedHamburguer { get; set; }
        public bool OrderedFries { get; set; }
        public bool OrderedMilkshake { get; set; }
        public bool OrderedDrink { get; set; }
        public List<HamburguerEnum>? Hamburguer { get; set; }
        public List<FriesEnum>? Fries { get; set; }
        public List<MilkshakeEnum>? Milkshake { get; set; }
        public List<DrinkEnum>? Drink { get; set; }
    }
}
