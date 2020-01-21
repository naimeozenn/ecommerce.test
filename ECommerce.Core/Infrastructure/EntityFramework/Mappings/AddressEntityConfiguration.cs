using ECommerce.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Core.Infrastructure.EntityFramework.Mappings
{
    public class DomainBaseEntityConfiguration : IEntityTypeConfiguration<DomainBase>
    {
        public void Configure(EntityTypeBuilder<DomainBase> builder)
        {
            builder.HasKey(model => model.Id);
        }
    }
}
