using ECommerce.Core.Command.Base;
using ECommerce.Core.Domain;
using ECommerce.Core.Infrastructure.EntityFramework.Contexts;
using System.Linq;

namespace ECommerce.Core.Command.Products
{
    public class GetProductCommand : ICommand<Product>
    {
        private readonly ECommerceDbContext _dbContext;
        
        public int ProductId { get; set; }
        public Product Execute()
        {

           return _dbContext.Product.FirstOrDefault(x => x.Id == ProductId);            
        }
    }
}
