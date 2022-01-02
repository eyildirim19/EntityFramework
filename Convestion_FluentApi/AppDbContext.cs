using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convestion_FluentApi
{
    public class AppDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        public DbSet<Categories> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;database=CustomDatabase2;uid=sa;pwd=123");
        }


        // fluent api ile konfigurasyon...
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // model oluşturulurken burayı referans alır...
            modelBuilder.Entity<Products>().ToTable("Urun"); // tablo ismi ürün
            modelBuilder.Entity<Categories>().ToTable("Kategori"); // tablo ismi kategori
            modelBuilder.Entity<Products>().HasKey(c => c.UrunID); // pk tanımlanaması...
            modelBuilder.Entity<Products>().Property(c => c.Name)
                .HasMaxLength(100) // nvarchar(100)
                .IsRequired() // not null
                .HasColumnName("UrunAdi");// kolon adı...

            // Relation...
            modelBuilder.Entity<Products>()
                .HasOne(c => c.Categories)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.KatId);
        }
    }
}