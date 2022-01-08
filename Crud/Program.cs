using System;
using System.Collections.Generic;
using System.Linq;

namespace Crud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ID,UserName,Password alanları olan bir sınıf oluşturunuz,
            // AppContext sınıfnını oluşturunuz..
            // Migration ile veritabanı oluşturunuz...
            // 5 dakikanınız var
            Console.WriteLine("Kullanıcı Eklemek için I'ya, güncelemek için U'ya, silmek için D, Listelemek için R tuşlarına basınız...");

            char operation = Convert.ToChar(Console.ReadLine());
            if (operation == 'I')
            {
                Console.WriteLine("Kullanıcı Adı Giriniz");
                string UserName = Console.ReadLine();

                Console.WriteLine("Şifre Giriniz");
                string password = Console.ReadLine();

                // user nesnemizi oluşturutoruz.. (User sınıfından instance alıyoruz)
                User user = new User();
                user.UserName = UserName;
                user.Password = password;


                AppDbContext dbContext = new AppDbContext(); // context sınfından instance alıyoruz..
                dbContext.Users.Add(user); // dbset'e veriyi ekliyoruz.. veri bellekte bekliyor..

                dbContext.SaveChanges(); // değişikliği veritabanına yansıt...
            }

            if (operation == 'U')
            {
                Console.WriteLine("Kullanıcı ID'sini giriniz");
                int ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Email Adresini giriniz");
                string email = Console.ReadLine();

                AppDbContext dbContext = new AppDbContext();

                // Find => verilen parametreye göre pk arama yapar ve bulunan kullanıcıyı döner...yoksa null döner...
                User user = dbContext.Users.Find(ID); // kullanıcı bulunursa belleğe alınır
                user.Email = email; // bellekteki email alanı güncellenir

                dbContext.SaveChanges(); // değişiklik veritabanıan yansıtılır...

            }

            if (operation == 'D')
            {
                Console.WriteLine("Kullanıcı ID'sini giriniz");
                int ID = Convert.ToInt32(Console.ReadLine());

                AppDbContext dbContext = new AppDbContext();

                User user = dbContext.Users.Find(ID);

                dbContext.Users.Remove(user); // dbsetteki userlardan sil...
                dbContext.SaveChanges(); // değişikliği veritabanına kaydet...
            }

            if (operation == 'R')
            {
                // kullanıcıları listle
                AppDbContext dbContext = new AppDbContext();
                List<User> users = dbContext.Users.ToList();

                Console.WriteLine("UserName \t Email \t CreDate");
                foreach (var u in users)
                {

                    Console.WriteLine($"{u.UserName} \t {u.Email} \t {u.CreDate}");
                }
            }

            Console.ReadKey();
        }
    }
}