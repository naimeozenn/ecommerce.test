using System;
namespace ECommerce.Core.Domain
{
    public class DomainBase
    {
        
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
