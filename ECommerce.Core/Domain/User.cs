using System.Text;

namespace ECommerce.Core.Domain
{
    public class User : DomainBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
