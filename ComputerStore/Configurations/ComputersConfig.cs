using ComputerStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputerStore.Configurations
{
    public class ComputersConfig : IEntityTypeConfiguration<Computers>
    {
        public void Configure(EntityTypeBuilder<Computers> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MarkaName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();
            builder.Property(x => x.ModelName)
                .HasColumnType("nvarchar(50)")
                .IsRequired();
            builder.Property(x => x.Size)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.HasOne(x => x.Details)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.DetailsId);
        }
    }
}
