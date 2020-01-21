using System.Collections.Generic;
using ECommerce.Core.Domain;

namespace ECommerce.Core.Services
{
    public interface IProductService
    {
        Product Get(int id);
        bool Update(Product product);
        bool Add(Product product);
        IList<Product> GetByCategory(int category);
    }
}