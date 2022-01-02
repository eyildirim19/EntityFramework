using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Giris2
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;Database=YeniYil2;uid=sa;pwd=123");
        }

        public DbSet<User> User { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Adress> Adres { get; set; }
    }
}