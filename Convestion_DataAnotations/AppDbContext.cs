using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convestion_DataAnotations
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;Database=CustomDatabase;uid=sa;pwd=123");
        }

        public DbSet<Categories> Category { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Suppliers> Suppliers { get; set; }
    }
}