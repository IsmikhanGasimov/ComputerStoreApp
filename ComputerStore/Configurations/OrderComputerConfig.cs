using ComputerStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Configurations
{
    public class OrderComputerConfig : IEntityTypeConfiguration<OrderComputer>
    {
        public void Configure(EntityTypeBuilder<OrderComputer> builder)
        {
            builder.HasKey(x => new {x.OrderId, x.ComputerId});

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderComputers)
                .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Computers)
                .WithMany(x => x.OrderComputers)
                .HasForeignKey(x => x.ComputerId);
        }
    }
}
