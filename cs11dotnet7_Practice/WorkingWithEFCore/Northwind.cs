using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithEFCore
{
    public class Northwind : DbContext
    {
        /* must have at lease one DbSet<T> type in the DbContext Class. These
         * properties represent the tables.
         */
        // these two properties map to tables in the database 
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
            string connection = $"Filename={path}";

            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"Connection: {connection}");
            ForegroundColor = previousColor;

            optionsBuilder.UseSqlite(connection);

            //enable Logging sensative data to console while debugging, remember to remove this before deploying.
            //optionsBuilder.LogTo(WriteLine).EnableSensitiveDataLogging();

            //What we need specified for event ID 20100:
            optionsBuilder.LogTo(WriteLine,
                new[] { RelationalEventId.CommandExecuting })
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //example of using Fluent API instead of attributes
            //to limit the length of a category name to 15
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            if (Database.ProviderName?.Contains("Sqlite") ?? false)
            {
                //added to "fix" the lack of decimal support in SQLite
                modelBuilder.Entity<Product>()
                    .Property(product => product.Cost)
                    .HasConversion<double>();
            }

            //global filter to remove discontinued products (property discontinued == true)
            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.Discontinued);
        }
    }

}
