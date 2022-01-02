using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris2
{
    public class User
    {
        // Kural : ef ile çalışırken sınıflarda pk tanımlanmak zorunludur... Ef default olarak bir property pk olarak tanımlayabilmesi için <EntityName>ID veya ID olarak isimlendirmek gerekir...
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreDate { get; set; }

        public int GenderId { get; set; }

        // class tipindeki propertylere navigation property denir...

        // Navigation propertyler sınıflar arası (tablolar) ilişki sağlamak için kullanılır...
        public Gender Gender { get; set; } //  bir cinsiyet

        public List<Adress> Adresses { get; set; } // çok adres

    }
}
