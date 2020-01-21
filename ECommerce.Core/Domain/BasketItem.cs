namespace ECommerce.Core.Domain
{
    public class BasketItem : DomainBase
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
