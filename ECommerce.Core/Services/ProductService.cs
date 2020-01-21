using System.Collections.Generic;
using System.Linq;
using ECommerce.Core.Domain;
using ECommerce.Core.Infrastructure.EntityFramework.Contexts;

namespace ECommerce.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly ECommerceDbContext _dbContext;

        public ProductService(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product Get(int id)
        {
            return _dbContext.Product.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Product product)
        {
            _dbContext.Product.Update(product);

            _dbContext.SaveChanges();

            return true;
        }

        public bool Add(Product product)
        {
            _dbContext.Product.Add(product);

            _dbContext.SaveChanges();

            return true;
        }

        public IList<Product> GetByCategory(int category)
        {
            return _dbContext.Product.Where(x => x.CategoryId == category).ToList();
        }
    }
}