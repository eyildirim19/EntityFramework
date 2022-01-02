using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convestion_FluentApi
{
    public class Products
    {
        public int UrunID { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public int KatId { get; set; }

        public Categories Categories { get; set; }
    }
}
