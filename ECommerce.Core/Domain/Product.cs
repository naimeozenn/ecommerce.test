namespace ECommerce.Core.Domain
{
    public class Product : DomainBase
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool InStock => Stock > 0;
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
    }
}
