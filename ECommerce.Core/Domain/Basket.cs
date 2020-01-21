using System.Collections.Generic;

namespace ECommerce.Core.Domain
{
    public class Basket : DomainBase
    {
        public User User { get; set; }
        public IList<BasketItem> Items { get; set; }
        public double Total { get; set; }
        public double ShipmentPrice { get; set; }
        public BasketStatus Status { get => (BasketStatus)StatusId; set => StatusId = (int)value; }
        public int StatusId { get; set; }
    }
}
