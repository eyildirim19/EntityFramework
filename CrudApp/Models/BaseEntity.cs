using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Models
{
    // Ortak özellikleri topladığımız entity sınıfmız...
    public class BaseEntity
    {
        // ctor tab tab
        public BaseEntity()
        {
            CreDate = DateTime.Now;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual DateTime CreDate { get; set; }
    }
}
