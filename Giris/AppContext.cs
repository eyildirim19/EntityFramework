using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Giris
{
    // CodeFirst yaklaşımında veritabanı bağlantılarından sorumlu olacak bir sınıf tanımlanmalıdır. Bu sınıf Context sınıfıdır.. veritabanı objeleri bu sınıf içerisinde işaretlenir..
    public class AppContext : DbContext
    {

        // Hangi veritabanı ile çalışacağız???
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // çalışılacak veri tabanı connection stringi yazılır..

            // oluşturlacak veritabanı adı belirtilir...
            optionsBuilder.UseSqlServer(@"Server=.\mssqlexpress;Database=YeniYil;uid=sa;pwd=123");
        }

        // veritabanı objeleri burada property olarak tanımlanır...
        public DbSet<Categories> Category { get; set; }

        // DbSet generic sınıfı Context içerisindeki propertyleri tablolar ile eşleştirmek için kullanılır...Uygulamadaki sınıflarınızın crud operasyonları tabi olması için DbSet olarak işertlenmesi gerekir...
    }
}