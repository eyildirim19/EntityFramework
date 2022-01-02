using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convestion_DataAnotations
{
    public class Suppliers
    {
        public int ID { get; set; }

        [StringLength(100)] // max 100
        public string Name { get; set; }

        [StringLength(50)] // nax 50
        public string ContanctTitle { get; set; }

        public List<Products> Products { get; set; }
    }
}