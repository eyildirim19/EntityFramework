using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convestion_FluentApi
{
    public class Categories
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Products> Products { get; set; }
    }
}
