using System.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           
            builder.ToTable("Product");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CodeBar).HasColumnType("VARCHAR(14)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("VARCHAR(60)");
            builder.Property( p => p.Value).IsRequired();
            builder.Property(p => p.ProductType).HasConversion<string>();

        }
    }
}
