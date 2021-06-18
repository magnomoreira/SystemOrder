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

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }

    }
}