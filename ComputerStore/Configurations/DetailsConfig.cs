using ComputerStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Configurations
{
    public class DetailsConfig : IEntityTypeConfiguration<Details>
    {
        public void Configure(EntityTypeBuilder<Details> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
