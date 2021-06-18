using System.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace System.Data.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnType("VARCHAR(60)").IsRequired();
            builder.Property(p => p.Telephone).HasColumnType("CHAR(11)");
            builder.Property(p => p.CEP ).HasColumnType("CHAR(8").IsRequired();
            builder.Property(p => p.State).HasColumnType("Char(2)").IsRequired();
            builder.Property( p => p.City).HasMaxLength(60).IsRequired();

            builder.HasIndex(i => i.Telephone).HasDatabaseName("idx_client_telephone");

        }
    }
}
