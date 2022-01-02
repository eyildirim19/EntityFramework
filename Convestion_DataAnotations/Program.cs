using System;

namespace Convestion_DataAnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            // EfCore Code First ile veritabanı oluştururken kurallar belirleme. Ef core default olarak tanımlamalar yapar.Örnek tablo isimleriniz property isimleri ile oluşur...

            // Bu varsayılan durumu değiştirmek için iki yöntem kullanılır;
            // 1) Data Anotation => Class veya Property Attribute ile veritabanı konfigurasyonu
            // 2) Fluent Api  => context sınıfı ile veritabanı konfiguraasyonu...

            Console.WriteLine("Hello World!");
        }
    }
}
