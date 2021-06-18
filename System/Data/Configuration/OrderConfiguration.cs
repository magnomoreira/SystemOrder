using System.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Initial).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.OrderStatus).HasConversion<string>();
            builder.Property(p => p.ShippingType).HasConversion<int>();
            builder.Property(p => p.Observation).HasColumnType("VARCHAR(512)");

                builder.HasMany(p => p.Iten)
                .WithOne(p => p)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
