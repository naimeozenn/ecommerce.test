namespace ECommerce.Core.Domain
{
    public class Address : DomainBase
    {
        public User User { get; set; }
        public string AddressLine { get; set; }
    }
}
