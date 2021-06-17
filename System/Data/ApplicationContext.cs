using Microsoft.EntityFrameworkCore;

namespace System.Data
{
    public class ApplicationContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb; initial Catalog=System;Integrated Security=true");
        }

    }
}