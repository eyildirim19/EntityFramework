using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Models
{
    public class CrudAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;database=CrudApp;uid=sa;pwd=123 ");
        }

        // EFCore tablo isimlerini property ismi ile oluşturur...
        public DbSet<User> Kullanici { get; set; }

        public DbSet<Categories> Kategori { get; set; }

        public DbSet<Shippers> Nakliyeci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>()
                .Property(c => c.Name)
                .HasColumnName("UserName")
                .HasMaxLength(20);

            modelBuilder.Entity<Shippers>()
                .Property(c => c.Name)
                .HasColumnName("ShipperName");

            modelBuilder.Entity<User>()
                .Property(c => c.IsLock)
                .HasDefaultValue(false);
        }
    }
}
