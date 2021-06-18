using System.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Data.Configuration
{
    public class OrderItenConfiguration : IEntityTypeConfiguration<OrderIten>
    {
        public void Configure(EntityTypeBuilder<OrderIten> builder)
        {
            builder.ToTable("OrderIten");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Quantity).HasDefaultValue(1).IsRequired();
            builder.Property(p => p.Value).IsRequired();
            builder.Property(p => p.Discont).IsRequired();

        }
    }
}
