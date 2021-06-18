using System.Domain;
using Microsoft.EntityFrameworkCore;

namespace System.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Product> Product { get ; set ; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb; initial Catalog=System;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Client>( p => {
                p.ToTable("Client");
                p.HasKey(p => p.Id);
                p.Property(p => p.Name).HasColumnType("VARCHAR(80)").IsRequired();
                p.Property(p => p.Telephone).HasColumnType("CHAR(11)");
                p.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();
                p.Property(p => p.State).HasColumnType("CHAR(2)").IsRequired();
                p.Property(p => p.City).HasMaxLength(60).IsRequired();

                p.HasIndex( i => i.Telephone).HasName("idx_client_telephone");
            });

            modelBuilder.Entity<Product>( p => {
                p.ToTable("Product");
                p.HasKey(p => p.Id);
                p.Property(p => p.CodeBar).HasColumnType("VARCHAR(14)").IsRequired();
                p.Property(p => p.Description).HasColumnType("VARCHAR(60)");
                p.Property( p => p.Value).IsRequired();
                p.Property(p => p.ProductType).HasConversion<string>();


            });

            modelBuilder.Entity<Order>( p => {
                p.ToTable("Order");
                p.HasKey(p => p.Id);
                p.Property(p => p.Initial).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                p.Property(p => p.OrderStatus).HasConversion<string>();
                p.Property(p => p.ShippingType).HasConversion<int>();
                p.Property(p => p.Observation).HasColumnType("VARCHAR(512)");

                p.HasMany(p => p.Iten)
                .WithOne(p => p)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<OrderIten>(p => {
                p.ToTable("OrderIten");
                p.HasKey(p => p.Id);
                p.Property(p => p.Quantity).HasDefaultValue(1).IsRequired();
                p.Property(p => p.Value).IsRequired();
                p.Property(p => p.Discont).IsRequired();
            });
        }

    }
}