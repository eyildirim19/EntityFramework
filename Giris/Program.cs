using System;

namespace Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            // O/RM (Object Relational Mapping) => veritabanı varlıkları ile uygulama varlıklarını eşleştiren yaklaşımdır. bu yaklaşımı kendi orm toollarımızı geliştirerek veya hazır toollar kullanarak uygulayabiliriz..

            // Entity Framework => Uygulama ile veritabanı arasına bağlantı sağlayan, crud operasyonlarımızı yürüten bir ORM tooldur. 

            // Entity Framework => tablo ile classları eşleştirir... 

            // Crud => Create (Insert),Read (select), Update, Delete isimlerinin kısaltmasıdır. Yani dml operasyonlarının app tarafındna yürütülmesidir..

            // Entity Framework Code First => Veritabanın uygulama tarafından oluşturulması yaklaşımıdır. Yani uygulama geliştirirken veri tabanı uygulamadaki kodlara göre oluşturulur. Referans uygulamadır..


            // Entity Framework'ü uygulamaya dahil etmek için Nuget Package Manager penceresinden dahil ederiz. Gerekli kütüphaneler;
            // Microsoft.EntityFrameworkCore =>  veritabanı bağlantı sınıflarını barındıran kütüphanedir...
            // Microsoft.EntityFrameworkCore.SqlServer => sql server ile çalışmak için ...

            // Ayrıca;
            // Microsoft.EntityFrameworkCore.Tools => Migration uygulamak için 

            // Migration =>  context sınıfı referans alınarak uygulama tarafından veritabanı oluşturulması, güncellenmesi gibi işlemleri yapacağımız apidir..

            // Migration işlemleri Package Manager Console penceresinden yapılır...

            // Migration yapılan değişikleri verisyonlar...veritabanı güncellemeden önce migration eklenmelidir..
            // add-migration komutu => migration ekle...
            // update-database komutu => veritabanını güncelle

            // Önce varlık(lar) oluşturulur..
            // daha sonra dbcontxt sınıfı oluşturulur. bu sınıf içerisindeki veritanı objeleri belirlenir..
            // daha sonra migration uygulanır

            Console.WriteLine("Hello World!");
        }
    }
}
