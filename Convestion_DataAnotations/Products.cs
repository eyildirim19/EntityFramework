using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convestion_DataAnotations
{
    // table attributesi sınıf ismini veritabanındaki karşılığını belirlemek (eşleştirmek) için kullanılır.. Bu Attribute System.ComponentModel.DataAnnotations.Schema namespace içerisindedir..
    [Table("Urun")]
    public class Products
    {
        [Key] // propertyi pk olarak işaretler.  System.ComponentModel.DataAnnotations namespacesi içerisindedir...
        public int UrunId { get; set; }

        [Column("UrunAdi")]
        [StringLength(100)] // nvarchar(100)
        public string ProductName { get; set; }

        public Nullable<int> Stok { get; set; } // Nullable property

        public decimal Price { get; set; } // not null

        [ForeignKey("Category")] // Foreign key tanımlıyoruz..Navigation Property ismi olacak...
        public int KatID { get; set; }

        public Categories Category { get; set; }

        public int SupplierID { get; set; } // NavigataionPropertyID olduğu için auto foreign key tanımlanacaktır...

        public Suppliers Supplier { get; set; }
    }
}