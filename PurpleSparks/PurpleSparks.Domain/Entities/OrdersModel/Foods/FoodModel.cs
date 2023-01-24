using PurpleSparks.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleSparks.Domain.Entities.OrdersModel.Foods
{
    public class FoodModel : Entity
    {
        public float Price { get; set; }
        public int? Quantity { get; set; }
    }
}
